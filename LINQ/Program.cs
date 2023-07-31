// See https://aka.ms/new-console-template for more information

var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

var evenNumbers = numbers.Where(FilterEvenNumbers).ToList();

numbers.Add(7);
numbers.Add(8);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

static bool FilterEvenNumbers(int num)
{
    return num % 2 == 0;
}

// Ordering
var animals = new List<string> { "Deer", "Sheep", "Cat", "Dog", "Bull", "Donkey", "Goat" };

foreach (var animal in animals.OrderBy(animal => animal))
{
    Console.WriteLine(animal);
}

foreach (var animal in animals.OrderByDescending(animal => animal))
{
    Console.WriteLine(animal);
}

var persons = new List<Person>
{
    new Person("John", "Deer"),
    new Person("John1", "Deer2"),
    new Person("John2", "Deer2"),
};

foreach (var person in persons.OrderBy(person => person.FirstName).ThenBy(person => person.FirstName))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

animals.Reverse();
foreach(var animal in animals)
{
    Console.WriteLine(animal);
}

record Person (string FirstName, string LastName);
