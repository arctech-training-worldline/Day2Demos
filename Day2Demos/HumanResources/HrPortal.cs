using Day2Demos.EmployeeService;
using System;
using System.Collections.Generic;

namespace Day2Demos.HumanResources
{
    internal class HrPortal
    {
        public void TestEmployeeManagement()
        {
            IEmployeeManagement employeeManagement = new EmployeeManagement();

            Employee e1 = new Employee
            {
                id = "E10101",
                name = "Ramesh",
                age = 25,
                salary = 10000
            };
            employeeManagement.Add(e1);

            Employee e2 = new Employee
            {
                id = "E20202",
                name = "Suresh",
                age = 35,
                salary = 20000
            };

            employeeManagement.Add(e2);
            
            List<Employee> allEmployees = employeeManagement.GetAllEmployees();
            List<Employee> suspendedEmployees = employeeManagement.GetAllSuspendedEmployees();

            PrintEmployeeReport(allEmployees);

            employeeManagement.Suspend("E20202");

            PrintEmployeeReport(allEmployees);
            PrintSuspendedEmployeeReport(suspendedEmployees);

            List<Employee> foundEmployees = employeeManagement.FindByName("Suresh");
            PrintFoundEmployees(foundEmployees);

            Employee foundEmployee = employeeManagement.GetById("E10101");
            PrintFoundEmployee(foundEmployee);
        }

        private void PrintSuspendedEmployeeReport(List<Employee> suspendedEmployees)
        {
            Console.WriteLine();
            Console.WriteLine("*** SUSPENDED EMPLOYEES ***");

            foreach (Employee employee in suspendedEmployees)
            {
                Console.WriteLine($"Id: {employee.id} Name: {employee.name} Age: {employee.age} Salary: {employee.salary}");
            }

            Console.WriteLine("*** SUSPENDED EMPLOYEES ***");
            Console.WriteLine();
        }

        private void PrintEmployeeReport(List<Employee> allEmployees)
        {
            Console.WriteLine();
            Console.WriteLine("*** CURRENT ACTIVE EMPLOYEES ***");
            
            foreach (Employee employee in allEmployees)
            {
                Console.WriteLine($"Id: {employee.id} Name: {employee.name} Age: {employee.age} Salary: {employee.salary}");
            }
            
            Console.WriteLine("*** CURRENT ACTIVE EMPLOYEES ***");
            Console.WriteLine();
        }

        private void PrintFoundEmployees(List<Employee> allEmployees)
        {
            Console.WriteLine();
            Console.WriteLine("*** FOUND EMPLOYEE(S) ***");

            foreach (Employee employee in allEmployees)
            {
                Console.WriteLine($"Id: {employee.id} Name: {employee.name} Age: {employee.age} Salary: {employee.salary}");
            }

            Console.WriteLine("*** FOUND EMPLOYEE(S) ***");
            Console.WriteLine();
        }

        private void PrintFoundEmployee(Employee employee)
        {
            Console.WriteLine();
            Console.WriteLine("*** FOUND EMPLOYEE(S) ***");

            Console.WriteLine($"Id: {employee.id} Name: {employee.name} Age: {employee.age} Salary: {employee.salary}");

            Console.WriteLine("*** FOUND EMPLOYEE(S) ***");
            Console.WriteLine();
        }

        public void TestLeaveManagement()
        {


        }
    }
}
