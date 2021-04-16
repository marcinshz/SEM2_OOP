using System;

namespace LAB01._3
{
    class Klient
    {
        private string nazwisko;
        private Konto konto;

        public Klient(int nrKonta, string nazwisko)
        {
            this.nazwisko = nazwisko;
            this.konto = new Konto(nrKonta, 0);
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Klient: " + nazwisko + " " + konto.PodajNrKonta());
        }
        public int stanKonta()
        {
            return konto.PodajSaldo();
        }
        public void Wplata(int kwota)
        {
            konto.Wplac(kwota);
        }
        public void Wyplata(int kwota)
        {
            konto.Wyplac(kwota);
        }
    }
    class Konto
    {
        private int nrKonta;
        private int saldo;

        public Konto(int nrKonta, int saldo)
        {
            this.nrKonta = nrKonta;
            this.saldo = saldo;
        }
        public int PodajNrKonta()
        {
            return nrKonta;
        }
        public int PodajSaldo()
        {
            return saldo;
        }
        public void Wplac(int kwota)
        {
            this.saldo += kwota;
        }
        public int Wyplac(int kwota)
        {
            if (kwota < saldo)
            {
                this.saldo -= kwota;
                return kwota;
            }
            Console.WriteLine($"Brak środków. Saldo: {saldo}");
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Klient k1 = new Klient(123456789, "Kowalski");

            k1.WyswietlDane();
            k1.Wplata(200);
            Console.WriteLine(k1.stanKonta());
            Console.ReadKey();
        }
    }
}
