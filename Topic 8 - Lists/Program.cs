// See https://aka.ms/new-console-template for more information
List<string> names = new List<string>{"Trinity", "Neo", "Morpheus", "Smith"};
Console.WriteLine(names[1] + " is 'The One'.");
Console.WriteLine(names[3] + " is the bad guy.");
Console.WriteLine("There are " + names.Count + " names in my List.");
names[3] = "Cypher";
Console.WriteLine(names[names.Count - 1] + " is the bad guy.");
Console.ReadLine(); // Keeps program from closing