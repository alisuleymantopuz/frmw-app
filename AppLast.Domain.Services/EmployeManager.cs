using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLast.Domain.EmployeeAggregate;

namespace AppLast.Domain.Services
{
    public class EmployeManager : IEmployeeManager
    {
        public IEmployeeRepository EmployeeRepository { get; private set; }

        public EmployeManager(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        public IList<Employee> GetAllEmployees()
        {
            return this.EmployeeRepository.List();
        }

        public Employee GetEmployeeById(int id)
        {
            return this.EmployeeRepository.Load(id);
        }
    }
}
