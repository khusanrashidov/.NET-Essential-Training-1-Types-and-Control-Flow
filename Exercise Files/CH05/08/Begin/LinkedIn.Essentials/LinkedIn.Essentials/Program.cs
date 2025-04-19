// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = null; // a nullable reference type
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 8;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 8, '0'));
input = "88888888";
Console.WriteLine(PadAndTrim(input, 9, 'K'));

static string PadAndTrim([AllowNull] string input, int length, char padChar)
{
    if (input == null)
        return String.Empty.PadLeft(length, padChar);
    else
        return input.Trim().PadLeft(length, padChar);
}