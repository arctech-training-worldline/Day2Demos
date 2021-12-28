using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demos.DataTypesSample
{
    // C# program to demonstrate the Sbyte
    // signed integral data type

    internal class DataTypesSample2
    {
        // Main function
        public static void Demo()
        {
            sbyte a = 126;

            // sbyte is 8 bit
            // singned value
            Console.WriteLine(a);

            a++;
            Console.WriteLine(a);

            // It overflows here because
            // byte can hold values
            // from -128 to 127
            a++;
            Console.WriteLine(a);

            // Looping back within
            // the range
            a++;
            Console.WriteLine(a);
        }
    }
}
