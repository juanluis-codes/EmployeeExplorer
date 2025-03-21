﻿// See https://aka.ms/new-console-template for more information

using EmployeeExplorer.Emp;
using EmployeeExplorer.Enterprise;
using System.ComponentModel;

static void DisplayMenu(Enterprise enterprise)
{
    Console.Write(String.Format("\nWelcome to EmployeeManager2025 ({0}):\n 1. Add a employee\n 2. Register vacations\n 3. Calculate bonus\n 4. Get Employee info\n 5. Fire Employee\n 6. Exit\nType a number: ", enterprise.GetEnterpriseName()));
}

static int GetEmployeeId()
{
    Console.Write("\nEmployee Id: ");
    return int.Parse(Console.ReadLine());
}

Enterprise enterprise = new Enterprise("Enterprise 1", DateTime.Now);

bool cont = true;
int vacationDays = 23;

Employee employee;
List<Employee> employees = new List<Employee>();
int empId;

while(cont)
{
    DisplayMenu(enterprise);
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("\nEmployee type (Salaried, Hourly, Freelancer): ");
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
                Console.Write("Contract duration (-1 for undefined): ");
                var duration = int.Parse(Console.ReadLine());

                employee = enterprise.AddSalariedEmployee(name, age, position, enterprise.GetEnterpriseName(), salary, duration);
                employees.Add(employee);
            }

            if (employeeType == "Hourly")
            {
                Console.Write("Payment per hour: ");
                var paymentHourly = float.Parse(Console.ReadLine());
                Console.Write("Hours: ");
                var hours = int.Parse(Console.ReadLine());

                employee = enterprise.AddHourlyEmployee(name, age, position, enterprise.GetEnterpriseName(), paymentHourly, hours);
                employees.Add(employee);
            }

            if (employeeType == "Freelancer")
            {
                Console.Write("Payment: ");
                var nextPayment = float.Parse(Console.ReadLine());
                Console.Write("Project: ");
                var project = Console.ReadLine();

                employee = enterprise.AddFreelancer(name, age, position, enterprise.GetEnterpriseName(), nextPayment, project);
                employees.Add(employee);
            }

            break;
        case 2:
            empId = GetEmployeeId();
            SalariedEmployee emp1 = (SalariedEmployee)employees.Find(emp => emp.EmployeeId == empId);

            if (emp1.GetType() != typeof(SalariedEmployee))
            {
                Console.WriteLine("Only Salaried Employees can register vacations");
                break;
            }

            Console.Write("Init date: ");
            var initDate = DateTime.Parse(Console.ReadLine());

            Console.Write("End date: ");
            var endDate = DateTime.Parse(Console.ReadLine());

            if (emp1.BookHolidays(initDate, endDate))
            {
                Console.WriteLine("Vacations registered");
            }
            else
            {
                Console.WriteLine("Vacations not registered");
            }

            break;
        case 3:
            empId = GetEmployeeId();
            IBonusable emp2 = (IBonusable)employees.Find(emp => emp.EmployeeId == empId);

            if(emp2.GetType() == typeof(Hourly) || emp2.GetType() == typeof(SalariedEmployee))
            {
                Console.Write("Objectives achieved: ");
                int obj = int.Parse(Console.ReadLine());
                Console.Write("Price per objective: ");
                float price = float.Parse(Console.ReadLine());

                Console.WriteLine("\nBonus: " + emp2.CalculateBonus(obj, price));
            }
            else
            {
                Console.WriteLine("\nEmployee not eligible for bonus");
            }

            break;
        case 4:
            empId = GetEmployeeId();
            Employee emp3 = employees.Find(emp => emp.EmployeeId == empId);
            Console.WriteLine("\n" + emp3);
            break;
        case 5:
            empId = GetEmployeeId();

            if (enterprise.FireEmployee(empId))
            {
                Console.WriteLine("\nEmployee fired");
            }
            else
            {
                Console.WriteLine("\nEmployee not found");
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
    Console.WriteLine("\n" + emp);

    if(emp.GetType() == typeof(SalariedEmployee))
    {
        foreach (string period in ((SalariedEmployee)emp).VacationPeriods)
        {
            Console.WriteLine(period);
        }
    }
}
