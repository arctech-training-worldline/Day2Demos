using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demos.LeaveService
{
    internal class Class1
    {
        public static void Test()
        {
            unsafe
            {
                int n = 10;
                int* p1 = &n;

                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p1);
                Console.WriteLine("Value at Address :{0}", *p1);
            }
        }
    }
}
