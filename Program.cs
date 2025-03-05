// See https://aka.ms/new-console-template for more information

using EmployeeExplorer.Employee;

SalariedEmployee employee1 = new SalariedEmployee("Juan", 24, "Data Engineer", DateTime.Now, 1000.0F, -1, 23);
Console.WriteLine("Hello, World!");
Console.WriteLine(employee1.GetEmployeeInfo());
