// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

Employee w = new ShiftWorker
{
    FirstName = "staff",
    LastName = "one",
    StartDate = new DateOnly(2024, 8, 8),
    ShiftStartTime = new TimeOnly(8, 8)
};
Console.WriteLine("=============Shift Worker=============");
bool payrollProcessed = w.ProcessPayroll();
w.Terminate(DateTime.Now);
bool active = w.IsActive();
Console.WriteLine();

ShiftWorker sw = new ShiftWorker
{
    FirstName = "staff",
    LastName = "one",
    StartDate = new DateOnly(2024, 8, 8),
    ShiftStartTime = new TimeOnly(8, 8)
};
Console.WriteLine("=============Shift Worker=============");
payrollProcessed = sw.ProcessPayroll();
sw.Terminate(DateTime.Now);
active = sw.IsActive();
Console.WriteLine();

Employee mgr = new Manager
{
    FirstName = "manager",
    LastName = "one",
    NumberOfDirectReports = 8
};
Console.WriteLine("=============Manager=============");
bool mgrPayrollProcessed = mgr.ProcessPayroll();
mgr.Terminate(DateTime.Now);
bool mgrActive = mgr.IsActive();
mgr.TerminateNew(DateTime.Now);
Console.WriteLine();
// So in this case, because we overrode that, it doesn't matter that the
// variable is an Employee. So that's the difference between override and
// new. When we override that base implementation, we're going to see,
// even when the variables of type Employee or the base class, you see the
// derived class implementation when the actual object is that derived
// class.

Manager m = new Manager
{
    FirstName = "manager",
    LastName = "one",
    NumberOfDirectReports = 8
};
Console.WriteLine("=============Manager=============");
mgrPayrollProcessed = m.ProcessPayroll();
m.Terminate(DateTime.Now);
mgrActive = m.IsActive();
m.TerminateNew(DateTime.Now);
Console.WriteLine();