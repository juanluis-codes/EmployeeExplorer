using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Emp
{
    class Employee
    {
        protected static int employeeId = 0;
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeePosition { get; set; }
        public DateTime EmployeeInitDate { get; set; }
        public bool EmployeeStatus { get; set; }

        public Employee(string name, int age, string position, DateTime initDate)
        {
            employeeId = employeeId++;
            EmployeeName = name;
            EmployeeAge = age;
            EmployeePosition = position;
            EmployeeInitDate = initDate;
            EmployeeStatus = true;
        }

        public virtual string GetEmployeeInfo()
        {
            if (!EmployeeStatus)
            {
                return "The employee status is not set";
            }

            var info = string.Format("Employee {0}, {1}. Contract for {2} started on {3}.", EmployeeName, EmployeeAge, EmployeePosition, EmployeeInitDate);
            return info;
        }
    }
}
