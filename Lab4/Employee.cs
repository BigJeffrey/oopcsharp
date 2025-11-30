using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }

        public IContract Contract { get; private set; }

        public Employee(string firstName, string lastName) : this(firstName, lastName, new Internship())
        {

        }

        public Employee(string firstName, string lastName, IContract contract)
        {
            FirstName = string.IsNullOrWhiteSpace(firstName) ? throw new ArgumentNullException(nameof(FirstName)) : firstName;
            LastName = string.IsNullOrWhiteSpace(lastName) ? throw new ArgumentNullException(nameof(LastName)) : lastName;
            Contract = contract ?? new Internship();
        }

        public void ZmienKontrakt(IContract newContract)
        {
            Contract = newContract ?? throw new ArgumentNullException(nameof(newContract));
        }

        public decimal Pensja()
        {
            return Contract.Salary();
        }

        public override string ToString()
        {
            return $"Pracownik {FirstName} {LastName} Pensja {Pensja().ToString("C", new CultureInfo("pl-PL"))} Kontrakt: {Contract}";
        }
    }
}
