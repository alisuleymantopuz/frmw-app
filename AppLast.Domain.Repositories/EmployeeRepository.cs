using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLast.Domain.EmployeeAggregate;
using Newtonsoft.Json;

namespace AppLast.Domain.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public RepositoryConfiguration RepositoryConfiguration { get; private set; }

        public EmployeeRepository(RepositoryConfiguration repositoryConfiguration)
        {
            RepositoryConfiguration = repositoryConfiguration;
        }

        public IList<Employee> List()
        {
            var stream = new FileStream(this.RepositoryConfiguration.DataFileFullName, FileMode.Open, FileAccess.Read);
            var streamReader = new StreamReader(stream);
            var dataContent = streamReader.ReadToEnd();

            #region CloseAndDisposeStreams
            streamReader.Close();
            streamReader.Dispose();
            stream.Close();
            stream.Dispose();
            #endregion

            var employees = (IList<Employee>)JsonConvert.DeserializeObject(dataContent, typeof(IList<Employee>));
            return employees;
        }

        public Employee Load(int id)
        {
            return this.List().FirstOrDefault(x => x.Id == id);
        }
    }
}
