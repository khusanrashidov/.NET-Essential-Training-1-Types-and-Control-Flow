// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

string input = null;
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

definiteInt = age != null ? age.Value : 21; // conditional ternary operator

definiteInt = age ?? 21; // null coalescing operator
Console.WriteLine($"Age is: {definiteInt}");
age = 20;
definiteInt = age ?? 21;
Console.WriteLine($"Age is: {definiteInt}");

age ??= 21; // null coalescing assignment
Console.WriteLine($"Age is: {age}");
age = null;
age ??= 21; // null coalescing assignment
Console.WriteLine($"Age is: {age}");

if (input != null)
{
    Console.WriteLine("String is: {0}", input);
}

//if (age != null)
//{
//    Console.WriteLine($"Age is: {age}");
//}
//
//if (age.HasValue)
//{
//    Console.WriteLine($"Age is: {age.Value}");
//}