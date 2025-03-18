// See https://aka.ms/new-console-template for more information

using EmployeeExplorer.Emp;
using EmployeeExplorer.Enterprise;
using System.ComponentModel;

static void DisplayMenu(Enterprise enterprise)
{
    Console.WriteLine(String.Format("Welcome to EmployeeManager2025 ({0}):\n 1. Add a employee\n 2. Register vacations\n 3. Calculate bonus\n 4. Get Employee info\n 5. Fire Employee\n 6. Exit\nType a number: ", enterprise.GetEnterpriseName));
}

Enterprise enterprise = new Enterprise("Enterprise 1", DateTime.Now);

bool cont = true;
int vacationDays = 23;
while(cont)
{
    DisplayMenu(enterprise);
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Employee type (Salaried, Hourly, Freelancer): ");
            var employeeType = Console.ReadLine();

            if (employeeType == "Salaried")
            {
                Console.Write("Name: ");
                var name = Console.ReadLine();
                Console.Write("Age: ");
                var age = int.Parse(Console.ReadLine());
                Console.Write("Position: ");
                var position = Console.ReadLine();
                Console.Write("Salary: ");
                var salary = float.Parse(Console.ReadLine());
                Console.Write("Contract duration: ");
                var duration = int.Parse(Console.ReadLine());

                enterprise.AddSalariedEmployee(name, age, position, salary, duration);
            }
            if(employeeType == "Hourly")
            {

            }

            if(employeeType == "Freelancer")
            {

            }

            break;
        case 6:
            cont = false;
            break;
        default:
            Console.WriteLine("Not implemented");
            break;
    }
}

foreach (Employee emp in enterprise.GetEmployees())
{
    Console.WriteLine(emp);
}
