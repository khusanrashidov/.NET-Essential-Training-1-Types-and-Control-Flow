// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

Employee e = new Employee("Kate", "Kane");
Console.WriteLine($"Hello from {e.FirstName} {e.LastName}.");
//e.NumberOfDirectReports = 1;

Employee k = new Manager("Kane", "Kate");
Console.WriteLine($"Hello from {k.FirstName} {k.LastName}.");
//k.NumberOfDirectReports = 1;

Manager m = new Manager("Kate", "Kane");
Console.WriteLine($"Hello from {m.FirstName} {m.LastName}.");
m.NumberOfDirectReports = 1;