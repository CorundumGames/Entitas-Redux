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
	/// Implement this interface if you want to create a system which should be executed in reaction to an event or
	/// data change.
	/// </summary>
	public interface IReactiveSystem : ISystem
	{
		/// <summary>
		/// Executed when the system has been activated.
		/// </summary>
		void Activate();

		/// <summary>
		/// Executed when the system has been de-activated.
		/// </summary>
		void Deactivate();

		/// <summary>
		/// Executed when the system should clear any accumulated changes.
		/// </summary>
		void Clear();

		/// <summary>
		/// Executes logic per render frame.
		/// </summary>
		void Execute();
	}
}
