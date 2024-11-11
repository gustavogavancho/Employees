using System.Collections.Generic;
using System.ServiceModel;

namespace Employees
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        List<Employee> GetEmployeeList();
    }
}
