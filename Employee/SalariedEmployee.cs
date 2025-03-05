using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Employee
{
    class SalariedEmployee : Employee, IBonusable, IDismissable
    {
        public float EmployeeSalary { get; set; }
        public int EmployeeContractDurationMonths { get; set; }
        public int EmployeeVacationDays { get; set; }
        public SalariedEmployee(string name, int age, string position, DateTime initDate, float salary, int contractDurationMonths, int vacationDays) : base(name, age, position, initDate)
        {
            EmployeeSalary = salary;
            EmployeeContractDurationMonths = contractDurationMonths;
            EmployeeVacationDays = vacationDays;
        }

        public int CalculateBonus(int objectivesAchieved, float pricePerObjective)
        {
            throw new NotImplementedException();
        }

        public int FireEmployee()
        {
            throw new NotImplementedException();
        }

        public override string GetEmployeeInfo()
        {
            if (!EmployeeStatus)
            {
                return "The employee status is not set";
            }

            var contractDuration = "";

            if(EmployeeContractDurationMonths == -1)
            {
                contractDuration = "undetermined";
            } else
            {
                contractDuration = Convert.ToString(EmployeeContractDurationMonths);
            }

                var info = String.Format("Employee {0}, {1}.\nContract for {2} started on {3} and ends on {4}.\nThe salary is {5}.\nCurrent holiday days: {6}", EmployeeName, EmployeeAge, EmployeePosition, EmployeeInitDate, contractDuration, EmployeeSalary, EmployeeVacationDays);
            return info;
        }
    }
}
