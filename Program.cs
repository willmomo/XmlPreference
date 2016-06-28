using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test8 {
	class Program {
		static void Main(string[] args) {
			Kjm.XmlPreference obj = new Kjm.XmlPreference();
			for (int i = 0; i < 100; i++) {
				obj.SetString("option", "key", i.ToString());
				Console.WriteLine(obj.GetString("option", "key", "-"));
			}
			obj.Dispose();
			obj = null;
		}
	}
}
