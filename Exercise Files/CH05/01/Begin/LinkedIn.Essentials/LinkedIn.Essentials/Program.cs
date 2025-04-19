// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

ShiftWorker d = new ShiftWorker()
{
    FirstName = "Dynamic",
    LastName = "Worker"
};
d.ShiftDays = ShiftDays.Wednesday;

Console.WriteLine(d.ShiftDays);

var day = DayOfWeek.Friday; // enum DayOfWeek
Console.WriteLine(day);
Console.WriteLine((double)day);

var shiftDay = ShiftDays.Friday;
Console.WriteLine(shiftDay);
Console.WriteLine((long)shiftDay);

shiftDay = ShiftDays.Wednesday;
Console.WriteLine(shiftDay);
Console.WriteLine((int)shiftDay);