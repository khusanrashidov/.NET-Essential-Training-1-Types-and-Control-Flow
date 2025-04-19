// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;
//using System;
using Newtonsoft.Json;

//string server = Constants.CONFIG_DB_NAME; // class Constant is internal not public

Employee e = new Manager();
e.FirstName = "Hello";
JsonSerializer s = new JsonSerializer();
s.Serialize(Console.Out, e);

//e.IsActive(); // It is inaccessible due to its protection level like internal, protected, private and only accessible here if its access modifier is public.

Console.WriteLine(e.FirstName);