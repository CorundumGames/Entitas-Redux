﻿/*

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

namespace JCMG.EntitasRedux
{
	/// <summary>
	/// Implement this interface if you want to create a component which
	/// you can add to an entity.
	/// Optionally, you can add these attributes:
	/// [Unique]: the code generator will generate additional methods for
	/// the context to ensure that only one entity with this component exists.
	/// E.g. context.isAnimating = true or context.SetResources();
	/// [MyContextName, MyOtherContextName]: You can make this component to be
	/// available only in the specified contexts.
	/// The code generator can generate these attributes for you.
	/// More available Attributes can be found in Entitas.CodeGeneration.Attributes/Attributes.
	/// </summary>
	public interface IComponent
	{
	}
}
