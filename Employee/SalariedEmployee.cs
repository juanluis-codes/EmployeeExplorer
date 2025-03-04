using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Employee
{
    class SalariedEmployee : Employee, IBonusable
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
    }
}
