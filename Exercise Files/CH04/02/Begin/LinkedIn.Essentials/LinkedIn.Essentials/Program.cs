// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

var m = 8;
var k = 8.0;
var x = ' ';
var y = "";

var e = new ShiftWorker();
e.FirstName = "Hello";
e.ShiftStartTime = new TimeOnly(8, 30);

Console.WriteLine(e.FirstName);