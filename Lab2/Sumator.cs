namespace Lab2
{
    internal class Sumator
    {
        private float[] liczby;

        public Sumator(float[] liczby)
        {
            this.liczby = liczby;
        }

        public float Suma()
        {
            float suma = 0;
            foreach (var liczba in liczby)
            {
                suma += liczba;
            }

            return suma;
        }

        public float SumaPodziel2() {
            float suma = 0;
            foreach (var liczba in liczby)
            {
                if (liczba % 2 == 0)
                    suma += liczba;
            }

            return suma;
        }

        public int IleElementow()
        {
            return liczby.Length;
        }

        public void WypiszElementy()
        {
            foreach (var liczba in liczby)
            {
                Console.WriteLine(liczba);
            }
        }

        public void WypiszOIndexach(int lowIndex, int highIndex)
        {
            if (lowIndex < 0) {
                lowIndex = 0;
            }
            if (highIndex > liczby.Length - 1)
            {
                highIndex = liczby.Length - 1;
            }

            for (int i = lowIndex; i <= highIndex; i++)
            {
                Console.WriteLine(liczby[i]);
            }
        }
    }
}
