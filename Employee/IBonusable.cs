using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExplorer.Employee
{
    interface IBonusable
    {
        float CalculateBonus(int objectivesAchieved, float pricePerObjective);
    }
}
