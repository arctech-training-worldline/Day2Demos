using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demos.Demo
{
    internal class Demo05Stack
    {
        public static void Test()
        {
            int ans1 = Add(10, 20);
            int ans2 = Subtract(100, 20);

            Console.WriteLine($"ans1 = {ans1}");
            Console.WriteLine($"ans2 = {ans2}");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
