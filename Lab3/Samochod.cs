using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Samochod : Pojazd
    {
        public override void Predkosc() => Console.WriteLine("Predkosc samochodu to 120 km/h");
    }
}
