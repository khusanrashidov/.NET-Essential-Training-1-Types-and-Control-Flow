// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

// object initialization with parenthesis
Employee e = new Employee()
{
    FirstName = "Kane",
    LastName = "Kate",
    EmployeeId = 1
};

// object initializer without parenthesis
Employee k = new Employee
{
    FirstName = "Kate",
    LastName = "Kane",
    EmployeeId = 8,
};

// object initialization
Employee m = new()
{
    FirstName = "Malika",
    LastName = "Khusan",
    EmployeeId = 8,
    StartDate = DateOnly.FromDateTime(DateTime.Now)
};

Employee x = new Employee("Khusan", "Malika")
{
    EmployeeId = 1,
    ShiftStartTime = TimeOnly.FromDateTime(DateTime.Now),
};

Console.WriteLine($"From {e.FirstName}, hello world. {e.Id}");
Console.WriteLine($"From {k.FirstName}, hello world. {k.Id}");
Console.WriteLine($"From {m.FirstName}, hello world. {m.Id}");
Console.WriteLine($"From {x.FirstName}, hello world. {x.Id}");