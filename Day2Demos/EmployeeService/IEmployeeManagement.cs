using System.Collections.Generic;

namespace Day2Demos.EmployeeService
{
    internal interface IEmployeeManagement
    {
        void Add(Employee newEmployee);
        void Delete(string employeeId);
        void Modify(Employee editedEmployee);
        Employee GetById(string employeeId);
        List<Employee> FindByName(string nameToFind);
        void Suspend(string employeeId);
        void RevokeSuspension(string employeeId);

        List<Employee> GetAllEmployees();
        List<Employee> GetAllSuspendedEmployees();
    }
}
