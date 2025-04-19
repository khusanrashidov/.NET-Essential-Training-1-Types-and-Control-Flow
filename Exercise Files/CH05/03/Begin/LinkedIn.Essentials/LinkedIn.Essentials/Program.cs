// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

ShiftWorker d = new ShiftWorker()
{
    FirstName = "Dynamic",
    LastName = "Worker"
};

bool availableFriday;
bool availableSaturdays;

d.DaysAvailable = ShiftDays.Weekdays;
availableFriday = d.DaysAvailable.HasFlag(ShiftDays.Friday);
Console.WriteLine($"Available Fridays {availableFriday}.");

availableSaturdays = (d.DaysAvailable & ShiftDays.Saturday) == ShiftDays.Saturday;
Console.WriteLine($"Available Saturdays {availableSaturdays}.");

d.DaysAvailable = ShiftDays.Weekend;
availableFriday = d.DaysAvailable.HasFlag(ShiftDays.Friday);
Console.WriteLine($"Available Fridays {availableFriday}.");

availableSaturdays = (d.DaysAvailable & ShiftDays.Saturday) == ShiftDays.Saturday;
Console.WriteLine($"Available Saturdays {availableSaturdays}.");

Console.WriteLine(d.DaysAvailable);

var shiftName = System.Enum.GetNames(typeof(ShiftDays));
Console.WriteLine($"{string.Join(", ", shiftName)}.");

Console.WriteLine($"{string.Join(", ", (short[])System.Enum.GetValues(typeof(ShiftDays)))}.");

var day = DayOfWeek.Monday;
//Console.WriteLine(day);
var shiftDay = ShiftDays.Tuesday;
//Console.WriteLine((int)shiftDay);