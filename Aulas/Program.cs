using Aulas.Models;
using System.Text.Json;

List<int> numbers = [1, 2, 3, 4, 5, 6];

List<Pessoa> pessoas = [];

foreach (int number in numbers)
{
    Pessoa people = new()
    {
        Name = "Wellington",
        Age = number,
    };
    pessoas.Add(people);

    if (people.Name.Contains("Wellington"))
    {
        Console.WriteLine($"Contem o: { people.Name }");
    }
}

if (numbers.Contains(6))
{
    Console.WriteLine($"Contem o número: {6}");
}

pessoas.Clear();

string json = JsonSerializer.Serialize(pessoas);
Console.WriteLine(json);
