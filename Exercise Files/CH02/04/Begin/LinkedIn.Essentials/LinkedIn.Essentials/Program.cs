// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

Employee e = new Employee("Khusan", "Malika", 8)
{
    StartDate = new DateOnly(2024, 8, 8)
};

Console.WriteLine($"From {e.FirstName} id {e.Id}, hello world.");

PremiereCustomer premiereCustomer = new PremiereCustomer(8);
premiereCustomer.FirstName = "Khusan";
//premiereCustomer.CustomerLevel = 8; // init-only property
Console.WriteLine($"{premiereCustomer.FirstName} has level {premiereCustomer.CustomerLevel}.");

PremiereCustomer premCust = new PremiereCustomer()
{
    FirstName = "Malika",
    CustomerLevel = 1
};
//premiereCustomer.CustomerLevel = 8; // init-only property
Console.WriteLine($"{premCust.FirstName} has level {premCust.CustomerLevel}.");

Manager m = new Manager("manager", "boss");
//m.NumberOfDirectReports = 8; // set accessor is inaccessable and get mutator is accessable
m.SetReports(8);