// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = "Kate";
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 20;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 8, '8'));
var shiftDay = GetShiftDays(DateTime.Now.DayOfWeek);
Console.WriteLine(shiftDay);
static ShiftDays GetShiftDays(DayOfWeek day) => day switch // switch expression C# 8
{
    DayOfWeek.Monday => ShiftDays.Monday,
    DayOfWeek.Tuesday => ShiftDays.Tuesday,
    DayOfWeek.Wednesday => ShiftDays.Wednesday,
    DayOfWeek.Thursday => ShiftDays.Thursday,
    DayOfWeek.Friday => ShiftDays.Friday,
    DayOfWeek.Saturday => ShiftDays.Saturday,
    DayOfWeek.Sunday => ShiftDays.Sunday,
    _ => ShiftDays.Friday
};

static string PadAndTrim([AllowNull] string input, int length, char padChar)
{
    if (input == null)
    {
        return string.Empty.PadLeft(length, padChar);
    }
    else if (input != null && input.Length <= length)
    {
        switch (padChar) // switch statement C# 6
        {
            case ' ':
            case '|':
                return input.Trim().PadLeft(length, padChar);
            case '0':
            case '8':
                return input.Trim().PadRight(length, padChar);
            default:
                Console.WriteLine("No match found for pad character.");
                break;
        }
        return input.Trim().PadLeft(length, padChar);
    }
    else
    {
        throw new ArgumentException("Input is longer than requested length.");
    }
}