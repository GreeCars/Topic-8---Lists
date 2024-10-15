// See https://aka.ms/new-console-template for more information
Random generator = new Random();
int randNum;

List<string> names = new List<string>{"Trinity", "Neo", "Morpheus", "Smith", "Tank"};
Console.WriteLine(names[1] + " is 'The One'.");
Console.WriteLine(names[3] + " is the bad guy.");
Console.WriteLine("There are " + names.Count + " names in my List.");
names[names.Count - 2] = "Cypher";
Console.WriteLine(names[names.Count - 2] + " is another bad guy.");
Console.ReadLine(); // Keeps program from closing

randNum = generator.Next(names.Count);
Console.WriteLine("Here is a random name:");
Console.WriteLine(names[randNum]);
Console.WriteLine();

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(i + ". " + names[i]);
}
Console.WriteLine();