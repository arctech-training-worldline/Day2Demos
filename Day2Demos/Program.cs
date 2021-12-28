using Day2Demos.HumanResources;

namespace Day2Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HrPortal hrPortal = new HrPortal();

            hrPortal.TestEmployeeManagement();
            //hrPortal.TestLeaveManagement();
        }
    }
}
