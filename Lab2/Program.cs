using Lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        // zadanie 1
        Person person = new Person("John", "Doe", 29);
        person.FirstName = "Jane";
        person.View();

        Person[] people = new Person[3];

        people[0] = new Person("Alice", "Smith", 34);
        people[1] = new Person("Bob", "Johnson", 45);   
        people[2] = new Person("Charlie", "Brown", 28); 
        foreach (Person personValue in people)
        {
            person.View();
        }

        // zadanie 2
        BankAccount konto = new BankAccount("Jan Kowalski", 1000);
        konto.Wplata(500);
        konto.Wyplata(200);
        Console.WriteLine($"Saldo: {konto.Saldo}");

        // zadanie 3
        Student student = new Student("Mateusz", "Serafin");
        student.DodajOcene(4.5f);
        student.DodajOcene(3.7f);
        Console.WriteLine($"Średnia ocen: {student.SredniaOcen()}");

        // zadanie 4
        Licz licz = new Licz(50.4f);
        Licz licz2 = new Licz(20);
        licz.Dodaj(0.5f);
        licz.Odejmij(0.9f);
        licz2.Dodaj(2);
        licz2.Odejmij(1);
        Console.WriteLine($"Wartość licz: {licz.Wartosc}, wartość licz2: {licz2.Wartosc}");

        // zadanie 5
        Sumator sumator = new Sumator(new float[] { 1, 2, 3 });
        sumator.WypiszElementy();
        Console.WriteLine(sumator.Suma());
        Console.WriteLine(sumator.SumaPodziel2());
        Console.WriteLine($"Suma elementów sumatora: {sumator.IleElementow()}");
        sumator.WypiszElementy();

        Console.WriteLine("Wypisz o indexach: ");
        sumator.WypiszOIndexach(0, 2);
    }
}