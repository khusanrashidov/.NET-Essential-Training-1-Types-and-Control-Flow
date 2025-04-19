// See https://aka.ms/new-console-template for more information.

// we are using alias for namespace to avoid being verbose in using types and avoid ambiguity
using LE = LinkedIn.Essentials;
using LET = LinkedIn.Essentials.Types;
//using System;
using Newtonsoft.Json;

// we alias a namespace for brevity in fully qualifying type names
LE.Employee e = new LET.Manager();
e.FirstName = "Hello";
JsonSerializer s = new JsonSerializer();
s.Serialize(Console.Out, e);

//e.IsActive();

Console.WriteLine(e.FirstName);