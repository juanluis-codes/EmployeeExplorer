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

        public float CalculateBonus(int objectivesAchieved, float pricePerObjective)
        {
            if (objectivesAchieved >= 1)
            {
                float bonus = (objectivesAchieved * pricePerObjective) + (EmployeeSalary * 0.05F);
                return bonus;
            }

            return 0.0F;
        }

        public bool BookHolidays(DateTime firstDay, DateTime lastDay)
        {
            if (firstDay.Year > DateTime.Now.Year | lastDay.Year > DateTime.Now.Year)
            {
                return false;
            }

            var days = (lastDay - firstDay).Days;

            if(days > EmployeeVacationDays)
            {
                return false;
            }

            EmployeeVacationDays = EmployeeVacationDays - days;
            return true;
        }

        public bool FireEmployee()
        {
            EmployeeStatus = false;
            return EmployeeStatus;
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
