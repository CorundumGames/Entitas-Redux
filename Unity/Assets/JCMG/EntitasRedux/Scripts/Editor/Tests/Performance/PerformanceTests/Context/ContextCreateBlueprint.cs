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

using JCMG.EntitasRedux;
using JCMG.EntitasRedux.Blueprints;

namespace EntitasRedux.Tests.Performance
{
	public class ContextCreateBlueprint : IPerformanceTest
	{
		private Blueprint _blueprint;
		private IContext<Entity> _context;

		private const int n = 100000;

		public void Before()
		{
			_context = Helper.CreateContext();

			var e = _context.CreateEntity();
			var component = new NameAgeComponent();
			component.name = "Max";
			component.age = 42;
			e.AddComponent(MyTestComponentsLookup.ComponentA, component);

			_blueprint = new Blueprint(string.Empty, string.Empty, e);
		}

		public void Run()
		{
			for (var i = 0; i < n; i++)
			{
				_context.CreateEntity().ApplyBlueprint(_blueprint);
			}
		}
	}

	public class NameAgeComponent : IComponent
	{
		public int age;
		public string name;
	}
}
