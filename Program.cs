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
Employee emp;
List<Employee> employees = new List<Employee>();

while(cont)
{
    DisplayMenu(enterprise);
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Employee type (Salaried, Hourly, Freelancer): ");
            var employeeType = Console.ReadLine();

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Position: ");
            var position = Console.ReadLine();

            if (employeeType == "Salaried")
            {
                Console.Write("Salary: ");
                var salary = float.Parse(Console.ReadLine());
                Console.Write("Contract duration: ");
                var duration = int.Parse(Console.ReadLine());

                emp = enterprise.AddSalariedEmployee(name, age, position, salary, duration);
                employees.Add(emp);
            }

            if(employeeType == "Hourly")
            {
                Console.Write("Payment per hour: ");
                var paymentHourly = float.Parse(Console.ReadLine());
                Console.Write("Hours: ");
                var hours = int.Parse(Console.ReadLine());

                emp = enterprise.AddHourlyEmployee(name, age, position, paymentHourly, hours);
                employees.Add(emp);
            }

            if(employeeType == "Freelancer")
            {
                Console.Write("Payment: ");
                var nextPayment = float.Parse(Console.ReadLine());
                Console.Write("Project: ");
                var project = Console.ReadLine();

                emp = enterprise.AddFreelancer(name, age, position, nextPayment, project);
                employees.Add(emp);
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
