using System;

namespace TestLib {
	public class Foo {
		public string GetTime() {
			return DateTime.Now.ToLongTimeString();
		}
	}
}
