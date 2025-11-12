namespace Lab2
{
    internal class Student
    {
        private string imie, nazwisko;
        private float[] oceny;

        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void DodajOcene(float ocena)
        {
            if (oceny == null)
            {
                oceny = new float[] { ocena };
            }
            else
            {
                Array.Resize(ref oceny, oceny.Length + 1);
                oceny[oceny.Length - 1] = ocena;
            }
        }

        public float SredniaOcen()
        {
            if (oceny == null || oceny.Length == 0)
            {
                throw new InvalidOperationException("Brak ocen do obliczenia średniej.");
            }
            float suma = 0;
            foreach (float ocena in oceny)
            {
                suma += ocena;
            }
            return suma / oceny.Length;
        }

    }
}
