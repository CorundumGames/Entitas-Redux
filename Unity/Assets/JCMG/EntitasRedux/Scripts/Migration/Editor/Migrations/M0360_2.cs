/*

MIT License

Copyright (c) 2020 Jeff Campbell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace JCMG.EntitasRedux.Migration.Editor
{
	internal sealed class M0360_2 : IMigration
	{
		private string MigrateBase(string fileContent)
		{
			fileContent = RemoveBase(fileContent, "ISetPools");
			fileContent = RemoveBase(fileContent, "ISetPool");
			fileContent = RemoveBase(fileContent, "IEnsureComponents");
			fileContent = RemoveBase(fileContent, "IExcludeComponents");

			fileContent = RenameBase(fileContent, "IReactiveSystem", "ReactiveSystem");

			return fileContent;
		}

		private string RemoveBase(string fileContent, string name)
		{
			fileContent = Regex.Replace(fileContent, @"(,\s*)" + name, string.Empty);
			fileContent = Regex.Replace(fileContent, @"(:\s*)" + name + @"(,\s*)", ": ");
			fileContent = Regex.Replace(fileContent, @"(:\s*)" + name, string.Empty);
			return fileContent;
		}

		private string RenameBase(string fileContent, string name, string replacement)
		{
			fileContent = Regex.Replace(fileContent, @"(,\s*)" + name, ", " + replacement);
			fileContent = Regex.Replace(fileContent, @"(:\s*)" + name + @"(,\s*)", ": " + replacement);
			fileContent = Regex.Replace(fileContent, @"(:\s*)" + name, ": " + replacement);
			return fileContent;
		}

		private string MigrateTrigger(string fileContent)
		{
			const string triggerPattern =
				@"public(\s|\n)*TriggerOnEvent(\s|\n)*trigger(\s|\n)*{(\s|\n)*get(\s|\n)*{(\s|\n)*return(\s|\n)*(?<trigger>(.|\s|\n)*?})(\s|\n)*}";
			const string triggerEventReplacement =
				"__ctor_placeholder__\n\n    protected override Collector GetTrigger(Context context) {{\n        return context.CreateCollector({0}, GroupEvent.{1});\n    }}\n\n__filter_placeholder__";
			const string triggerReplacement =
				"__ctor_placeholder__\n\n    protected override Collector GetTrigger(Context context) {{\n        return context.CreateCollector({0});\n    }}\n\n__filter_placeholder__";

			var oldTrigger = Regex.Match(fileContent, triggerPattern).Groups["trigger"].Value;
			var groupEvent = Regex.Match(oldTrigger, @".OnEntity(?<event>\w*)").Groups["event"].Value;
			var oldMatcher = Regex.Match(oldTrigger, @".*(?=.OnEntity)");

			if (groupEvent == "Added")
			{
				fileContent = Regex.Replace(fileContent, triggerPattern, match => string.Format(triggerReplacement, oldMatcher));
			}
			else
			{
				fileContent = Regex.Replace(
					fileContent,
					triggerPattern,
					match => string.Format(triggerEventReplacement, oldMatcher, groupEvent));
			}

			return fileContent;
		}

		private string MigrateToFilter(string fileContent)
		{
			const string ensurePattern =
				@"public(\s|\n)*IMatcher(\s|\n)*ensureComponents(\s|\n)*{(\s|\n)*get(\s|\n)*{(\s|\n)*return(\s|\n)*(?<matcher>(.|\s|\n)*?);(\s|\n)*}(\s|\n)*}";
			var ensureMatcher = Regex.Match(fileContent, ensurePattern).Groups["matcher"].Value;

			const string excludePattern =
				@"public(\s|\n)*IMatcher(\s|\n)*excludeComponents(\s|\n)*{(\s|\n)*get(\s|\n)*{(\s|\n)*return(\s|\n)*(?<matcher>(.|\s|\n)*?);(\s|\n)*}(\s|\n)*}";
			var excludeMatcher = Regex.Match(fileContent, excludePattern).Groups["matcher"].Value;

			var ensureFilter = GetFilter(ensureMatcher);
			if (!string.IsNullOrEmpty(ensureFilter))
			{
				ensureFilter = "(" + ensureFilter + ")";
			}

			var excludeFilter = GetFilter(excludeMatcher);
			if (!string.IsNullOrEmpty(excludeFilter))
			{
				excludeFilter = "!(" + excludeFilter + ")";
			}

			var filter = "true";
			if (ensureFilter != null)
			{
				filter = ensureFilter;
			}

			if (excludeFilter != null)
			{
				if (ensureFilter == null)
				{
					filter = excludeFilter;
				}
				else
				{
					filter += " && " + excludeFilter;
				}
			}

			const string filterReplacement =
				@"    protected override bool Filter(Entity entity) {{
        // TODO Entitas 0.36.0 Migration
        // ensure was: {0}
        // exclude was: {1}

        return {2};
    }}";

			fileContent = Regex.Replace(fileContent, ensurePattern, string.Empty);
			fileContent = Regex.Replace(fileContent, excludePattern, string.Empty);
			fileContent = Regex.Replace(
				fileContent,
				@"__filter_placeholder__",
				string.Format(
					filterReplacement,
					ensureMatcher,
					excludeMatcher,
					filter));

			return fileContent;
		}

		private string GetFilter(string matcher)
		{
			const string allOfPattern = @"AllOf(\s|\n)*\((\s|\n)*(?<matchers>(.|\s|\n)*?)\)";
			const string anyOfPattern = @"AnyOf(\s|\n)*\((\s|\n)*(?<matchers>(.|\s|\n)*?)\)";
			const string noneOfPattern = @"NoneOf(\s|\n)*\((\s|\n)*(?<matchers>(.|\s|\n)*?)\)";

			var ensureAllOf = string.Empty;
			if (Regex.IsMatch(matcher, allOfPattern))
			{
				ensureAllOf = string.Join(
					" && ",
					Regex.Match(matcher, allOfPattern)
						.Groups["matchers"]
						.Value
						.Split(',')
						.Select(m => m.Trim())
						.Select(m => m.Split('.')[1])
						.Select(m => "entity.has" + m)
						.ToArray());
			}

			var ensureAnyOf = string.Empty;
			if (Regex.IsMatch(matcher, anyOfPattern))
			{
				ensureAnyOf = string.Join(
					" || ",
					Regex.Match(matcher, anyOfPattern)
						.Groups["matchers"]
						.Value
						.Split(',')
						.Select(m => m.Trim())
						.Select(m => m.Split('.')[1])
						.Select(m => "entity.has" + m)
						.ToArray());
			}

			var ensureNoneOf = string.Empty;
			if (Regex.IsMatch(matcher, noneOfPattern))
			{
				ensureNoneOf = string.Join(
					" && !",
					Regex.Match(matcher, noneOfPattern)
						.Groups["matchers"]
						.Value
						.Split(',')
						.Select(m => m.Trim())
						.Select(m => m.Split('.')[1])
						.Select(m => "entity.has" + m)
						.ToArray());
			}

			var filters = new List<string>();

			if (!string.IsNullOrEmpty(ensureAllOf))
			{
				ensureAllOf = "(" + ensureAllOf + ")";
				filters.Add(ensureAllOf);
			}

			if (!string.IsNullOrEmpty(ensureAnyOf))
			{
				ensureAnyOf = "(" + ensureAnyOf + ")";
				filters.Add(ensureAnyOf);
			}

			if (!string.IsNullOrEmpty(ensureNoneOf))
			{
				ensureNoneOf = "(!" + ensureNoneOf + ")";
				filters.Add(ensureNoneOf);
			}

			if (filters.Count == 0)
			{
				if (Regex.IsMatch(matcher, @"\w*Matcher.\w*"))
				{
					filters.Add(matcher.Split('.')[1]);
				}
			}

			return filters.Count == 0
				? null
				: string.Join(" && ", filters.ToArray());
		}

		private string MigrateSetPoolsSetPool(string fileContent)
		{
			const string setPoolsPattern =
				@"public(\s|\n)*void(\s|\n)*SetPools(\s|\n)*\((\s|\n)*Contexts(\s|\n)*pools(\s|\n)*\)(\s|\n)*{(\s|\n)*(?<logic>(.|\s|\n)*?)(\s|\n)*}";
			var setPoolsLogic = Regex.Match(fileContent, setPoolsPattern).Groups["logic"].Value;
			Regex.Replace(fileContent, setPoolsPattern, string.Empty);

			const string setPoolPattern =
				@"public(\s|\n)*void(\s|\n)*SetPool(\s|\n)*\((\s|\n)*Context(\s|\n)*pool(\s|\n)*\)(\s|\n)*{(\s|\n)*(?<logic>(.|\s|\n)*?)(\s|\n)*}";
			var setPoolLogic = Regex.Match(fileContent, setPoolPattern).Groups["logic"].Value;
			Regex.Replace(fileContent, setPoolPattern, string.Empty);

			var classNamePattern = @"public(\w|\s|\n)*class(\s|\n)(?<className>\w*)";
			var className = Regex.Match(fileContent, classNamePattern).Groups["className"].Value;

			const string constructorFormat =
				@"public {0}(Contexts contexts) : base(context) {{
{1}
    }}";

			var construtorLogic = new List<string>();
			if (!string.IsNullOrEmpty(setPoolsLogic))
			{
				construtorLogic.Add("        " + setPoolsLogic);
			}

			if (!string.IsNullOrEmpty(setPoolLogic))
			{
				construtorLogic.Add("        " + setPoolLogic);
			}

			if (fileContent.Contains("__ctor_placeholder__"))
			{
				fileContent = fileContent.Replace(
					"__ctor_placeholder__",
					string.Format(constructorFormat, className, string.Join("    \n", construtorLogic.ToArray())));

				fileContent = Regex.Replace(fileContent, setPoolsPattern, string.Empty);
				fileContent = Regex.Replace(fileContent, setPoolPattern, string.Empty);
			}
			else
			{
				fileContent = Regex.Replace(
					fileContent,
					setPoolsPattern,
					match => "// TODO Entitas 0.36.0 Migration (constructor)\n    " + match.Value);
				fileContent = Regex.Replace(
					fileContent,
					setPoolPattern,
					match => "// TODO Entitas 0.36.0 Migration (constructor)\n    " + match.Value);
			}

			return fileContent;
		}

		private string MigrateExecute(string fileContent)
		{
			const string reactiveSystemExecute = @"public(\s|\n)*void(\s|\n)*Execute(\s|\n)*\((\s|\n)*List";
			const string reactiveSystemExecuteUsing =
				@"public(\s|\n)*void(\s|\n)*Execute(\s|\n)*\((\s|\n)*System.Collections.Generic.List";

			if (Regex.IsMatch(fileContent, reactiveSystemExecuteUsing))
			{
				fileContent = Regex.Replace(
					fileContent,
					reactiveSystemExecute,
					"protected override void Execute(System.Collections.Generic.List");
			}
			else if (Regex.IsMatch(fileContent, reactiveSystemExecute))
			{
				fileContent = Regex.Replace(
					fileContent,
					reactiveSystemExecute,
					"protected override void Execute(List");
			}

			return fileContent;
		}

		public string Version
		{
			get { return "0.36.0-2"; }
		}

		public string WorkingDirectory
		{
			get { return "where systems are located"; }
		}

		public string Description
		{
			get { return "Migrates systems"; }
		}

		public MigrationFile[] Migrate(string path)
		{
			var files = MigrationUtils.GetFiles(path);

			for (var i = 0; i < files.Length; i++)
			{
				var file = files[i];

				file.fileContent = MigrateBase(file.fileContent);
				file.fileContent = MigrateTrigger(file.fileContent);
				file.fileContent = MigrateToFilter(file.fileContent);
				file.fileContent = MigrateSetPoolsSetPool(file.fileContent);
				file.fileContent = MigrateExecute(file.fileContent);
			}

			return files;
		}
	}
}
