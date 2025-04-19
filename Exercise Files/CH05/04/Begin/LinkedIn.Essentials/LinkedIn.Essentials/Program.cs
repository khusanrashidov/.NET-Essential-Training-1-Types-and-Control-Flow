// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

// Variables can be null, meaning they can point to nothing.
// reference type variables can have a null value whereas value type variables can have a null value when they are nullable value types
string input = null;
string? output = null;
long definiteInt = null;
long? age = null; // That question mark make that int nullable, meaning it makes it of type 'int?' (not just 'int') to have a value of null.
Nullable<long> age2 = null;

if (input != null)
    Console.WriteLine($"String is: {input}");
if (age != null)
    Console.WriteLine(age);