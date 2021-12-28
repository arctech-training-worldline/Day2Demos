using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demos.Demo
{
	class SadEmployee
    {
		string name;

		public void Add()
        {
			string s = "Hello";
			SadEmployee se = new SadEmployee();
        }
    }

    internal class Demo04ValueTypes
    {
        public static void Test()
        {
			// declaring string
			string a = "Geeks";

			//append in a
			a += "for";
			a = a + "Geeks";
			Console.WriteLine(a);
			Console.WriteLine(a.GetType());

			SadEmployee se = new SadEmployee();
			Console.WriteLine(se.GetType());

			// declare object obj
			object obj;
			obj = 20;
			//obj = "Hello";
			// Why is this not giving compilation error?
			Console.WriteLine(obj);

			// to show type of object
			// using GetType()
			Console.WriteLine(obj.GetType());
		}
    }
}
