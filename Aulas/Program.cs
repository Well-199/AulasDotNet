using Aulas.Models;
using System.Text.Json;

List<int> numbers = [10, 9, 8, 7, 6, 5, 5, 3, 3, 1];

List<Pessoa> pessoas = [];

numbers.RemoveAt(3);
numbers.Insert(3, 12);

numbers.Sort();

foreach (int number in numbers)
{
    Pessoa people = new()
    {
        Name = "Wellington",
        Age = number,
    };
    pessoas.Add(people);

    Console.WriteLine($"Numeros: {number}");

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
