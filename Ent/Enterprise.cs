using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeExplorer.Emp;
using EmployeeExplorer.Ent;

namespace EmployeeExplorer.Enterprise
{
    class Enterprise: IEnterprise
    {
        private readonly string enterpriseName;
        private readonly int vacations = 23;
        private readonly DateTime enterpriseFoundation;
        protected List<Employee> Employees { get; set; }

        public Enterprise(string name, DateTime foundation)
        {
            enterpriseName = name;
            enterpriseFoundation = foundation;
            Employees = new List<Employee>();
        }

        public string GetEnterpriseName()
        {
            return enterpriseName;
        }

        public DateTime GetEnterpriseFoundation()
        {
            return enterpriseFoundation;
        }

        public bool FireEmployee(int employeeId)
        {
            Employees.Remove(Employees.Find(emp => emp.EmployeeId == employeeId));
            return true;
        }

        public bool AddSalariedEmployee(string name, int age, string position, float salary, int duration)
        {
            var employee = new SalariedEmployee(name, age, position, DateTime.Now, salary, duration, vacations);
            Employees.Add(employee);
            return true;
        }
    }
}
