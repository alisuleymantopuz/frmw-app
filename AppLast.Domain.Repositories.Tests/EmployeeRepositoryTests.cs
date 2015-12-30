using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace AppLast.Domain.Repositories.Tests
{
    [TestClass]
    public class EmployeeRepositoryTests
    {
        [TestMethod]
        public void list_should_be_success()
        {
            var repositoryConfiguration = new RepositoryConfiguration();
            var employeeRepository = new EmployeeRepository(repositoryConfiguration);
            var employees = employeeRepository.List();
            Assert.IsNotNull(employees);
            employees.Count.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void load_should_be_success()
        {
            var repositoryConfiguration = new RepositoryConfiguration();
            var employeeRepository = new EmployeeRepository(repositoryConfiguration);
            var employee = employeeRepository.Load(1);
            employee.Should().NotBeNull();
            employee.Id.Should().Be(1);
        }
    }
}
