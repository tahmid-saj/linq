﻿// See https://aka.ms/new-console-template for more information

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

/*var persons = new List<Person>
{
    new Person("John", "Deer"),
    new Person("John1", "Deer2"),
    new Person("John2", "Deer2"),
};*/

/*foreach (var person in persons2.OrderBy(person => person.FirstName).ThenBy(person => person.FirstName))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}*/

animals.Reverse();
foreach(var animal in animals)
{
    Console.WriteLine(animal);
}

var persons2 = new List<Person>
{
    new Person("John", "Miller", 27),
    new Person("John1", "Miller1", 28),
    new Person("John2", "Miller2", 31),
};

var lastNames = persons2.Select(person => person.LastName);

foreach(var lastName in lastNames)
{
    Console.WriteLine(lastName);
}

var ageBetween20and30 = persons2.Where(person => person.Age >= 20 && person.Age <= 30)
                                .Select(person => person.Age);

foreach (var age in ageBetween20and30)
{
    Console.WriteLine(age);
}

var firstPerson = persons2.First();
Console.WriteLine(firstPerson.FirstName);

foreach(var person in persons2.Skip(1).Take(2))
{
    Console.WriteLine(person.FirstName);
}

var employees = new List<Employee>
{
    new Employee("John", "Miller", "Development"),
    new Employee("Jack", "Stevens", "Sales"),
    new Employee("Maria", "McAllister", "Sales"),
};

var selectedEmployees = from employee in employees 
                        where employee.FirstName.StartsWith("J") 
                        orderby employee.LastName
                        select employee;

Console.WriteLine("\n");

foreach(var employee in selectedEmployees)
{
    Console.Write(employee.FirstName);
}

Console.WriteLine("\n");

var employeesByDepartment = from employee in employees
                            group employee by employee.Department into groupedEmployees
                            orderby groupedEmployees.Key
                            select groupedEmployees;

foreach (var department in employeesByDepartment)
{
    Console.WriteLine($"Department: {department.Key}");

    foreach (var employee in department)
    {
        Console.WriteLine($"{employee.FirstName} {employee.LastName}");
    }
}

Console.WriteLine("\n");

var personsByDepartment = employees.GroupBy(person => person.Department);

foreach(var department in personsByDepartment)
{
    Console.WriteLine($"Department: {department.Key}");

    foreach(var employee in department) {
        Console.WriteLine($"{employee.FirstName} {employee.LastName}");
    }
}

record Person (string FirstName, string LastName, int Age);

record Employee(string FirstName, string LastName, string Department);
