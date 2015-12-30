using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLast.Domain.Repositories
{
    public class RepositoryConfiguration
    {
        public string DataFileFullName { get { return ConfigurationManager.AppSettings["DataFileFullName"]; } }
    }
}
