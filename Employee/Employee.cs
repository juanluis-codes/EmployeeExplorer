using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Employee
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeePosition { get; set; }
        public DateTime EmployeeInitDate { get; set; }

        public Employee(string name, int age, string position, DateTime initDate)
        {
            EmployeeName = name;
            EmployeeAge = age;
            EmployeePosition = position;
            EmployeeInitDate = initDate;
        }
    }
}
