using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Emp
{
    class Employee
    {
        protected static int numberOfEmployees = 0;
        protected bool employeeStatus;
        public int EmployeeId { get; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeePosition { get; set; }
        public DateTime EmployeeInitDate { get; set; }

        public Employee(string name, int age, string position, DateTime initDate)
        {
            numberOfEmployees = numberOfEmployees++;
            EmployeeId = numberOfEmployees;
            EmployeeName = name;
            EmployeeAge = age;
            EmployeePosition = position;
            EmployeeInitDate = initDate;
            employeeStatus = true;
        }

        public override string ToString() {
            return GetEmployeeInfo();
        }

        public virtual string GetEmployeeInfo()
        {
            if (!employeeStatus)
            {
                return "Employee is no longer available";
            }

            var info = string.Format("Employee {0}, {1}. Contract for {2} started on {3}.", EmployeeName, EmployeeAge, EmployeePosition, EmployeeInitDate);
            return info;
        }
    }
}
