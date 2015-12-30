using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLast.Domain.EmployeeAggregate
{
    public interface IEmployeeManager
    {
        IList<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}
