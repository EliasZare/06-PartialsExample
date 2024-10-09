// See https://aka.ms/new-console-template for more information
using _06_PartialsExample;
using System.Xml.Linq;
using partial2 = Partial2;
Console.WriteLine("Hello, World!");
PartialClass partialClass = new PartialClass(id: 1, name: "Elias", bio: "C# Dev");
Console.WriteLine("My name is " + partialClass.GetName());
Console.WriteLine("I'm "+partialClass.GetBio());
partial2.PartialClass partialClass1 = new partial2.PartialClass();
Console.ReadKey();