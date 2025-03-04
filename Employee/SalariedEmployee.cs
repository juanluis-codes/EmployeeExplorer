using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Employee
{
    class SalariedEmployee : Employee, IBonusable
    {
        public float Salary { get; set; }
        public int ContractDurationMonths { get; set; }
        public SalariedEmployee(string name, int age, string position, DateTime initDate) : base(name, age, position, initDate)
        {
        }

        public int CalculateBonus(int objectivesAchieved, float pricePerObjective)
        {
            throw new NotImplementedException();
        }
    }
}
