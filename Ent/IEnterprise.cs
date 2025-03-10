using EmployeeExplorer.Emp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeExplorer.Ent
{
    interface IEnterprise
    {
        public bool AddSalariedEmployee(string name, int age, string position, float salary, int duration);
        public bool FireEmployee(int employeeId);
    }
}
