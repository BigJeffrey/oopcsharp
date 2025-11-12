namespace Lab2
{
    internal class BankAccount
    {
        private decimal saldo;
        private String wlasciciel;

        public BankAccount(String wlasciciel, decimal initialSaldo)
        {
            this.wlasciciel = wlasciciel;
            this.saldo = initialSaldo;
        }

        public void Wplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                throw new ArgumentException("Kwota wpłaty musi być większa od zera.");
            }

            saldo += kwota;
        }

        public void Wyplata(decimal kwota)
        {
            if (kwota <= 0)
            {
                throw new ArgumentException("Kwota wypłaty musi być większa od zera.");
            }

            if (kwota > saldo)
            {
                throw new InvalidOperationException("Niewystarczające środki na koncie.");
            }

            saldo -= kwota;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }
    }
}
