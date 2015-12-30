using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppLast.Contracts.Service;
using AppLast.Contracts.Data;
using AppLast.Services.Assemblers;
using AppLast.Domain.EmployeeAggregate;

namespace AppLast.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployeeServiceAssembler EmployeeServiceAssembler { get; private set; }

        public IEmployeeManager EmployeeManager { get; private set; }

        public EmployeeService(IEmployeeServiceAssembler employeeServiceAssembler, IEmployeeManager employeeManager)
        {
            EmployeeManager = employeeManager;
            EmployeeServiceAssembler = employeeServiceAssembler;
        }

        public IList<EmployeeInfo> EmployeeListOperation()
        {
            var employees = this.EmployeeManager.GetAllEmployees();

            var employeeInfoCollection = this.EmployeeServiceAssembler.GetEmployeeInfo(employees);

            return employeeInfoCollection;
        }

        public EmployeeInfo EmployeeOperation(int employeeId)
        {
            var employee = this.EmployeeManager.GetEmployeeById(employeeId);

            var employeeInfo = this.EmployeeServiceAssembler.GetEmployeeInfo(employee);

            return employeeInfo;
        }
    }
}