﻿// See https://aka.ms/new-console-template for more information.
using LinkedIn.Essentials;
//using System;
using Newtonsoft.Json;

//string db = Constants.CONFIG_DB_NAME;
//Console.WriteLine(db);

Employee e = new Manager();
e.FirstName = "Hello";
JsonSerializer s = new JsonSerializer();
s.Serialize(Console.Out, e);

Console.WriteLine(e.FirstName);