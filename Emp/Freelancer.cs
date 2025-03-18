using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Emp
{
    class Freelancer: Employee
    {
        public float NextPayment { get; set; }
        public string Project { get; set; }

        public Freelancer(string name, int age, string position, DateTime initDate, float nextPayment, string project): base(name, age, position, initDate)
        {
            NextPayment = nextPayment;
            Project = project;
        }

        public override string ToString()
        {
            return GetEmployeeInfo();
        }

        public override string GetEmployeeInfo()
        {
            if (!employeeStatus)
            {
                return "Employee is no longer available";
            }

            var info = string.Format("Freelancer {0}, {1}.\nContract for {2} started on {3}.\nThe next payment is {4} euros.\nCurrent project: {5}", EmployeeName, EmployeeAge, EmployeePosition, EmployeeInitDate, NextPayment, Project);
            return info;
        }
    }
}
