// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

string input = null;
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 5;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

Console.WriteLine($"Age is: {definiteInt}");

Console.WriteLine($"'{PadAndTrim(input, 8, '0')}'");
static string PadAndTrim(string input, int length, char padChar)
{
    return input?.Trim()?.PadLeft(length, padChar);
}
static string? TrimAndPad(string input, int length, char padChar)
{
    return input?.Trim()?.PadLeft(length, padChar);
}
Console.WriteLine($"'{TrimAndPad(input!, 8, '0')}'");