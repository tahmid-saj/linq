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