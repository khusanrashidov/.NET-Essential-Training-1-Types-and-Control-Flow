﻿// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;

var x = 10.0;
var y = "some string";

dynamic d = new ShiftWorker
{
    FirstName = "Kate",
    LastName = "Kane",
};

Console.WriteLine(d.FirstName);
string kid1 = d.Kids[1];