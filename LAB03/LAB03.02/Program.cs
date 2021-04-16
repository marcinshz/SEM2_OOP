using System;

namespace LAB03._02
{
    class Rachunek
    {
        private int numer;
        protected double saldo = 0;

        public Rachunek(int numer)
        {
            this.numer = numer;
        }

        public bool Wplac(double kwota)
        {
            if (kwota <= 0)
            {
                return false;
            }
            saldo += kwota;
            return true;
        }

        public bool Wyplac(double kwota)
        {
            if (kwota <= 0 || kwota > saldo)
            {
                return false;
            }
            saldo -= kwota;
            return true;
        }

        public string Podaj()
        {
            return numer + " " + saldo;
        }
    }
    class Rachunek_oszczednosciowy : Rachunek
    {
        public double procent;
        
        public Rachunek_oszczednosciowy(int numer, double procent) : base(numer)
        {
            this.procent = procent;
        }

        public void naliczOdsetki()
        {
            saldo = saldo + (saldo * procent);
        }
    }
    class Rachunek_debetowy : Rachunek
    {
        public double debet;
        
        public Rachunek_debetowy(int numer, double debet) : base(numer)
        {
            this.debet = debet;
        }
        public new bool Wyplac(double kwota)
        {
            if (kwota <= 0 || kwota > saldo+debet)
            {
                return false;
            }
            saldo -= kwota;
            return true;
        }

    }
    class Bank
    {
        Rachunek[] bank;
        public Bank(Rachunek[] bank)
        {
            this.bank = bank;
        }
        public void obliczOdsetki()
        {
            for (int i = 0; i < bank.Length; i++)
            {
                if(bank[i] is Rachunek_oszczednosciowy)
                {
                    ((Rachunek_oszczednosciowy)bank[i]).naliczOdsetki();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rachunek r1 = new Rachunek(1);
            //Console.WriteLine(r1.Podaj());

            Rachunek_debetowy r3 = new Rachunek_debetowy(3, 100);
            r3.Wplac(50);
            Console.WriteLine(r3.Podaj());
            r3.Wyplac(100);
            Console.WriteLine(r3.Podaj());
            Rachunek[] Bank = {r1, r3};
            Bank b = new Bank(Bank);
        }
    }
}
