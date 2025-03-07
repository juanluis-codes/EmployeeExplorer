// See https://aka.ms/new-console-template for more information

using EmployeeExplorer.Employee;


public void DisplayMenu()
{
    Console.WriteLine("Welcome to EmployeeManager2025:\n 1. Add a employee\n 2. Register vacations\n 3. Calculate bonus");
}

bool cont = true;
while(cont)
{

}

SalariedEmployee employee1 = new SalariedEmployee("Juan", 24, "Data Engineer", DateTime.Now, 1000.0F, -1, 23);
Console.WriteLine("Hello, World!");
Console.WriteLine(employee1.GetEmployeeInfo());
