using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AppLast.Contracts.Data;

namespace AppLast.Contracts.Service
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        IList<EmployeeInfo> EmployeeListOperation();

        [OperationContract]
        EmployeeInfo EmployeeOperation(int employeeId);

    }
}
