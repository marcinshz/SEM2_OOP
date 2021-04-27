using System;

namespace PD07._07
{
    class Wlamanie : ApplicationException
    {
        public Wlamanie(string message) : base(message) { }
    }
    class ZepsutyZamek : ApplicationException
    {
        public ZepsutyZamek(string message) : base(message) { }
    }
    class Nieczynne : ApplicationException
    {
        public Nieczynne(string message) : base(message) { }
    }
    class BrakMiejsca : ApplicationException
    {
        public BrakMiejsca(string message) : base(message) { }
    }
    class BrakTowaru : ApplicationException
    {
        public BrakTowaru(string message) : base(message) { }
    }
    enum Informacja { Włamanie = -5, ZepsutyZamek, Nieczynne, BrakMiejsca, BrakTowaru, OK = 1 };
    class Magazyn
    {
        int ile;
        string[] towary;
        bool otwarty = false;
        int kod;

        public Magazyn(int kod)
        {
            ile = 0;
            towary = new string[5];
            this.kod = kod;
        }

        public void Otwórz(int kod)
        {
            if (this.kod == kod)
            {
                otwarty = true;
                return;
            }
            throw new Wlamanie("Włamanie!");
        }

        public void Zamknij(int kod)
        {
            if (this.kod == kod)
            {
                otwarty = false;
                return;
            }
            throw new ZepsutyZamek("Zepsuty zamek!");
        }

        public void DodajTowar(string towar)
        {
            if (!otwarty) throw new Nieczynne("Nieczynne");
            for (int i = 0; i < towary.Length; i++)
                if (towary[i] == null)
                {
                    towary[i] = towar;
                    ile++;

                    return;
                }
            throw new BrakMiejsca("Brak miejsca w magazynie!");
        }

        public void WydajTowar(string name)
        {
            if (!otwarty) throw new Nieczynne("Nieczynne");
            for (int i = 0; i < towary.Length; i++)
                if (towary[i] != null)
                {
                    if (towary[i] == name)
                    {
                        towary[i] = null;
                        return;
                    }
                }
            throw new BrakTowaru("Nie ma tego towaru");
        }

        public void Pokaz()
        {
            if (otwarty) Console.WriteLine("magazyn otwarty");
            else Console.WriteLine("magazyn zamknięty");
            foreach (string towar in towary)
                if (towar != null) Console.WriteLine(towar);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string odpowiedź = "t";
            Random akcja = new Random();

            Magazyn b = new Magazyn(3);
            b.Otwórz(3);
            for (int i = 2; i < 6; i++) b.DodajTowar("towar" + i);
            b.Pokaz();
            b.Zamknij(3);

        }
    }
}
