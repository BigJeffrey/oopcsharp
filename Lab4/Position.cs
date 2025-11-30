using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Position : IContract
    {
        public Position()
        {
            MonthlyRate = 5000m;
            Overtime = 0;
        }

        public Position(decimal monthlyRate, int overtime)
        {
            MonthlyRate = monthlyRate;
            Overtime = overtime;
        }

        public decimal MonthlyRate { get; set; }   
        public int Overtime { get; set; }

        public decimal Salary()
        {
            return MonthlyRate + Overtime * (MonthlyRate / 60m);
        }

        public override string ToString()
        {
            return $"Etat ({MonthlyRate.ToString("C", new System.Globalization.CultureInfo("pl-PL"))} + {Overtime}h nadgodzin)";
        }
    }
}
