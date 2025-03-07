// See https://aka.ms/new-console-template for more information

using EmployeeExplorer.Employee;


static void DisplayMenu()
{
    Console.WriteLine("Welcome to EmployeeManager2025:\n 1. Add a employee\n 2. Register vacations\n 3. Calculate bonus\n 4. Get Employee info\n 5. Fire Employee\n 6. Exit\nType a number: ");
}

bool cont = true;
while(cont)
{
    DisplayMenu();
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 6:
            cont = false;
            break;
        default:
            Console.WriteLine("Not implemented");
            break;
    }
}

SalariedEmployee employee1 = new SalariedEmployee("Juan", 24, "Data Engineer", DateTime.Now, 1000.0F, -1, 23);
Console.WriteLine("Hello, World!");
Console.WriteLine(employee1.GetEmployeeInfo());
