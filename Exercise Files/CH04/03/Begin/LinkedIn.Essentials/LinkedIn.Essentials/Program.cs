// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

var e = new { FirstName = "Malika", LastName = "Khusan", Kids = new string[] { "son1", "son2", }, }; // anonymous type
//e.FirstName = "Hello"; // readonly property
string kid1 = e.Kids[1]; // anonymous types are powerful when creating objects with hierarchy
//((ShiftWorker)e).ShiftStartTime = new TimeOnly(8, 30); // we cannot cast anonymous types

Console.WriteLine(e.FirstName + e.LastName);

// Anonymous types get used in a number of different scenarios in C-sharp
// sometimes with Asp.net web pages, other cases where we used language
// integrated query to project or create new object types on the fly with
// some state. And in those cases that var keyword is critical because we
// don't know that type ahead of time by name. We will know what the
// structure looks like and how to use it.