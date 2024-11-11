using System.Collections.Generic;

namespace Employees
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe", Position = "Manager", Salary = 60000 },
                new Employee { Id = 2, Name = "Jane Smith", Position = "Developer", Salary = 50000 },
                new Employee { Id = 3, Name = "Samuel Green", Position = "Designer", Salary = 45000 }
            };
        }
    }
}
