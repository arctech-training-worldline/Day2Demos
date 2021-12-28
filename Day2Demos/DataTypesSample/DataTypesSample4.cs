using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demos.DataTypesSample
{
    internal class DataTypesSample4
    {
		// Main Function
		static void Demo()
		{

			// declaring string
			string a = "Geeks";

			//append in a
			a += "for";
			a = a + "Geeks";
			Console.WriteLine(a);

			// declare object obj
			object obj;
			obj = 20;
			Console.WriteLine(obj);

			// to show type of object
			// using GetType()
			Console.WriteLine(obj.GetType());
		}
	}
}
