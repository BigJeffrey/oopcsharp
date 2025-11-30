using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Internship : IContract
    {
        public Internship() {
            StawkaMiescieczna = 1000m;
        }
        
        public Internship(decimal stawkaMiesieczna)
        {
            StawkaMiescieczna = stawkaMiesieczna;
        }

        public decimal Salary()
        {
            return StawkaMiescieczna;
        }

        public decimal StawkaMiescieczna { get; set; }

        public override string ToString()
        {
            return $"Staż ({StawkaMiescieczna.ToString("C", new CultureInfo("pl-PL"))})";
        }
    }
}
