using AppLast.Contracts.Data;
using AppLast.Domain.EmployeeAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLast.Services.Assemblers
{
    public class EmployeeServiceAssembler : IEmployeeServiceAssembler
    {

        public IList<EmployeeInfo> GetEmployeeInfo(IList<Employee> employees)
        {
            return employees.Select(x => new EmployeeInfo()
            {
                Id = x.Id,
                Email = x.Email,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
        }

        public EmployeeInfo GetEmployeeInfo(Employee employee)
        {
            return new EmployeeInfo()
            {
                Email = employee.Email,
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname
            };
        }
    }
}