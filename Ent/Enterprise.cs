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
        private List<Employee> Employees { get; set; }

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

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public bool FireEmployee(int employeeId)
        {
            Employee employee = Employees.Find(emp => emp.EmployeeId == employeeId);

            if (employee.FireEmployee())
            {
                Employees.Remove(employee);
                return true;
            }

            return false;
        }

        public SalariedEmployee AddSalariedEmployee(string name, int age, string position, float salary, int duration)
        {
            var employee = new SalariedEmployee(name, age, position, DateTime.Now, salary, duration, vacations);
            Employees.Add(employee);
            return employee;
        }

        public Hourly AddHourlyEmployee(string name, int age, string position, float paymentHourly, int hours)
        {
            var employee = new Hourly(name, age, position, DateTime.Now, paymentHourly, hours);
            Employees.Add(employee);
            return employee;
        }

        public Freelancer AddFreelancer(string name, int age, string position, float nextPayment, string project)
        {
            var employee = new Freelancer(name, age, position, DateTime.Now, nextPayment, project);
            Employees.Add(employee);
            return employee;
        }
    }
}
