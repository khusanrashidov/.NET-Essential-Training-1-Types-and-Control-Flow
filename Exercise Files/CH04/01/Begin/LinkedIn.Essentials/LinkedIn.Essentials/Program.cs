// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

Employee e = new ShiftWorker();
e.FirstName = "Hello";
//e.ShiftStartTime = new TimeOnly(8, 20); // Employee does not contain a definition for ShiftStartTime that ShiftWorker has.

ShiftWorker s = new ShiftWorker();
s.FirstName = "Hello";
s.ShiftStartTime = new TimeOnly(8, 20);

IPerson i = new ShiftWorker();
i.FirstName = "Hello";
((ShiftWorker)i).ShiftStartTime = new TimeOnly(8, 20);

Console.WriteLine(e.FirstName);