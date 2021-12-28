namespace Day2Demos.EmployeeService
{
    internal class Employee
    {
        public string id;
        public string name;
        public int age;
        public double salary;
    }

    public class TestClass
    {
        void Test()
        {
            Employee emp = new Employee();
            emp.id = "E101345";
        }
    }
}
