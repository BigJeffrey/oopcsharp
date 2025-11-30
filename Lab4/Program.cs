// See https://aka.ms/new-console-template for more information
using Lab4;

Employee emp1 = new Employee("Jan", "Kowalski");
Employee emp2 = new Employee("Anna", "Nowak", new Position(6000m, 10)); 

Console.WriteLine(emp1);
Console.WriteLine(emp2);

emp1.ZmienKontrakt(new Position(5500m, 5));
Console.WriteLine("Po zmianie kontraktu:");
Console.WriteLine(emp1);