using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeExplorer.Emp;

namespace EmployeeExplorer.Enterprise
{
    class Enterprise
    {
        private readonly string enterpriseName;
        private readonly DateTime enterpriseFoundation;
        protected List<Employee> Employees { get; set; }

        public Enterprise(string name, DateTime foundation)
        {
            enterpriseName = name;
            enterpriseFoundation = foundation;
            Employees = new List<Employee>();
        }
    }
}
