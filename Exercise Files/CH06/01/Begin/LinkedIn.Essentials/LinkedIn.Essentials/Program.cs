// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = "Kane";
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 21;
age ??= 12;
definiteInt = age ?? 17;

//definiteInt = age != null ? age.Value : 17;

Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 8, '8'));

static string PadAndTrim([AllowNull] string input, int length, char padChar)
{
    if (input == null)
    {
        return String.Empty.PadLeft(length, padChar);
    }

    else if (input != null && input.Length <= length)
    {
        switch (padChar) // C# 6 switch
        {
            case ',': break;
            case ' ':
            case '|':
                return input.Trim().PadLeft(length, padChar);
            case '8':
            case '0': return input.Trim().PadRight(length, padChar);
            case '.': goto case ' ';
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