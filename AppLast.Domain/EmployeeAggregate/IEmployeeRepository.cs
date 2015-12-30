using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLast.Domain.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        IList<Employee> List();
        Employee Load(int id);
    }
}
