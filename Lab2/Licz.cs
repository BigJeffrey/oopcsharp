namespace Lab2
{
    internal class Licz
    {
        private float value;

        public Licz(float value)
        {
            this.value = value;
        }

        public void Dodaj(float doDodania)
        {
            value += doDodania;
        }

        public void Odejmij(float doOdjecia)
        {
            value -= doOdjecia;
        }

        public float Wartosc
        {
            get { return value; }
        }
    }
}
