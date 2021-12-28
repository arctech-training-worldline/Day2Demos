using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demos.Demo
{
    internal class Demo02ValueTypes
    {
        public static void Test()
        {
            // sbyte => 8 bits => -128 to +127
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
