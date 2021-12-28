using System.Collections.Generic;

namespace Day2Demos.EmployeeService
{
    internal class EmployeeManagement : IEmployeeManagement
    {
        private readonly List<Employee> employees = new List<Employee>();
        private readonly List<Employee> suspendedEmployees = new List<Employee>();

        public void Add(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }

        public void Delete(string employeeId)
        {
            foreach (var employee in employees)
            {
                if (employee.id == employeeId)
                {
                    employees.Remove(employee);
                    break;
                }
            }
        }

        public void Modify(Employee editedEmployee)
        {
            foreach (var employee in employees)
            {
                if (employee.id == editedEmployee.id)
                {
                    employee.id = editedEmployee.id;
                    employee.name = editedEmployee.name;
                    employee.salary = editedEmployee.salary;
                    employee.age = editedEmployee.age;

                    break;
                }
            }
        }

        public Employee GetById(string employeeId)
        {
            foreach (var employee in employees)
            {
                if (employee.id == employeeId)
                    return employee;                    
            }

            return null;
        }

        public List<Employee> FindByName(string nameToFind)
        {
            List<Employee> matchingEmployees = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.name.Contains(nameToFind))
                    matchingEmployees.Add(employee);
            }

            return matchingEmployees;
        }

        public void Suspend(string employeeId)
        {
            foreach (var employee in employees)
            {
                if (employee.id == employeeId)
                {
                    suspendedEmployees.Add(employee);
                    employees.Remove(employee);
                    break;
                }
            }
        }

        public void RevokeSuspension(string employeeId)
        {
            foreach (var employee in suspendedEmployees)
            {
                if (employee.id == employeeId)
                {
                    employees.Add(employee);
                    suspendedEmployees.Remove(employee);
                    break;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public List<Employee> GetAllSuspendedEmployees()
        {
            return suspendedEmployees;
        }
    }
}
