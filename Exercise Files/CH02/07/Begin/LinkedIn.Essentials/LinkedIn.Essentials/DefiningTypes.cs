namespace LinkedIn.Essentials;

// the derived class must implement properties and methods of the interface as well as abstract methods and abstract properties of the abstract class
// only abstract type can have abstract methods and abstract properties

public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public abstract class Employee : IPerson
{
    // IPerson
    public string LastName { get; set; }
    public string FirstName { get; set; }


    public DateOnly StartDate { get; set; }

    // virtual property
    public virtual DateTime EndDate { get; set; }

    // abstract property
    public abstract int EmployeeId { get; }

    // derived must implement
    public abstract bool ProcessPayroll();

    // derived can implement
    public virtual void Terminate(DateTime terminationEffectiveDate)
    {
        Console.WriteLine("Employee terminated.");
        EndDate = terminationEffectiveDate;
    }
    public virtual void TerminateNew(DateTime terminationEffectiveDate)
    {
        Console.WriteLine("Employee terminated.");
        EndDate = terminationEffectiveDate;
    }

    // derived can call or hide
    public bool IsActive()
    {
        Console.WriteLine("Employee active.");
        DateOnly current = DateOnly.FromDateTime(DateTime.Now);
        return current > StartDate && DateTime.Now < EndDate;
    }

    // we can only override only virtual and abstract methods and properties
}

public class ShiftWorker : Employee
{
    public TimeOnly ShiftStartTime { get; set; }
    public override int EmployeeId { get => 1; }

    public override bool ProcessPayroll()
    {
        Console.WriteLine("Shiftworker payroll.");
        return true;
    }
    public new bool IsActive() // We use `new` keyword to hide inherited method from base class, meaning, by hiding we imply giving our own implementation of that method or property in the derived class that is different from what in the base class.
    {
        base.IsActive(); // Using the actual IsActive() method from the base class in the derived class's method.
        Console.WriteLine("Shiftworker active.");
        return false;
    }
}

public class Manager : Employee, IPerson
{
    public int NumberOfDirectReports { get; set; }
    public override int EmployeeId { get => new System.Random().Next(1, 100); }

    public override bool ProcessPayroll()
    {
        Console.WriteLine("Manager payroll.");
        return true;
    }

    public override void Terminate(DateTime terminationEffectiveDate)
    {
        // perform manager specific termination steps
        Console.WriteLine("Manager terminated.");

        // optional - call base implementation
        base.Terminate(terminationEffectiveDate);
    }
    public new void TerminateNew(DateTime terminationEffectiveDate)
    {
        // perform manager specific termination steps
        Console.WriteLine("Manager terminated.");

        // optional - call base implementation
        base.Terminate(terminationEffectiveDate);
    }
}