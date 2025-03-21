using EmployeeExplorer.Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeExplorer.Ent
{
    interface IEnterprise
    {
        public SalariedEmployee AddSalariedEmployee(string name, int age, string position, string enterpriseName, float salary, int duration);
        public Hourly AddHourlyEmployee(string name, int age, string position, string enterpriseName, float paymentHourly, int hours);
        public Freelancer AddFreelancer(string name, int age, string position, string enterpriseName, float nextPayment, string project);
        public bool FireEmployee(int employeeId);
    }
}
