using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demos.Demo
{
    internal class Demo06Pointers
    {
        public static void Test()
        {
            int a = 10;

            unsafe
            {
                Console.WriteLine($"1. a = {a}, Address of a = {(int)&a}");

                int* address1 = &a;                

                Console.WriteLine($"3. address1 = {(int)address1}, What is found at this address = {*address1}");
            }
        }
    }
}
