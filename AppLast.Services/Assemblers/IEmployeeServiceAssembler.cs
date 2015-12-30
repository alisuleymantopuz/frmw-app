using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLast.Contracts.Data;

namespace AppLast.Services.Assemblers
{
    public interface IEmployeeServiceAssembler
    {
        IList<EmployeeInfo> GetEmployeeInfo(IList<Domain.EmployeeAggregate.Employee> employees);

        EmployeeInfo GetEmployeeInfo(Domain.EmployeeAggregate.Employee employee);
    }
}
