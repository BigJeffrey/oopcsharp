using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student : Person
    {
        private int nrAlbumu;

        public Student(string name, int age, int nrAlbumu) : base(name, age)
        {
            this.nrAlbumu = nrAlbumu;
        }

        public void ViewStudent()
        {
            View();
        }
    }
}