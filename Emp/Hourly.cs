using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Emp
{
    class Hourly: Employee, IBonusable
    {
        private float payment;
        public int Hours { get; set; }
        public float PaymentPerHour{ get; set; }

        public Hourly(string name, int age, string position, DateTime initDate, float paymentHourly, int hours) : base(name, age, position, initDate)
        {
            PaymentPerHour = paymentHourly;
            Hours = hours;
            payment = PaymentPerHour * Hours;
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

            var info = string.Format("Hourly Employee {0}, {1}.\nContract for {2} started on {3}.\nActual paycheck of {4} euros ({5} hours, {6} euros/h)", EmployeeName, EmployeeAge, EmployeePosition, EmployeeInitDate, payment, Hours, PaymentPerHour);
            return info;
        }

        public float CalculateBonus(int objectivesAchieved, float pricePerObjective)
        {
            if (!employeeStatus)
            {
                return 0.0F;
            }

            if (objectivesAchieved >= 1)
            {
                float bonus = objectivesAchieved * pricePerObjective + payment * 0.05F;
                return bonus;
            }

            return 0.0F;
        }
    }
}
