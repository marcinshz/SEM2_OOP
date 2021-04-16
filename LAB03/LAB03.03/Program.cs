using System;

namespace LAB03._03
{
    class Samochod
    {
        public int rokProdukcji;
        public string marka;
        public double predkoscMax;
        protected double predkosc;

        public Samochod(int rokProdukcji, string marka, double predkoscMax, double predkosc)
        {
            this.rokProdukcji = rokProdukcji;
            this.marka = marka;
            this.predkoscMax = predkoscMax;
            this.predkosc = predkosc;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Marka: {marka}, Rok produkcji: {rokProdukcji}, Prędkość maksymalna: {predkoscMax}, Aktualna predkosc: {predkosc}");
        }
    }
    class SamochodKierowany : Samochod
    {
        public SamochodKierowany(int rokProdukcji, string marka, double predkoscMax, double predkosc) : base(rokProdukcji, marka, predkoscMax, predkosc)
        {
            this.predkosc = predkosc;
        }
        public bool Przyspiesz(double wartosc)
        {
            if (wartosc > 0)
            {
                if (predkosc + wartosc <= predkoscMax)
                {
                    predkosc += wartosc;
                    return true;
                }
                else if (predkosc < predkoscMax && predkosc + wartosc > predkoscMax)
                {
                    predkosc = predkoscMax;
                    return true;
                }
            }
            return false;
        }

        public bool Zwolnij(double wartosc)
        {
            if (wartosc > 0)
            {
                if (predkosc - wartosc >= 0)
                {
                    predkosc -= wartosc;
                    return true;
                }
                else if (predkosc > 0 && predkosc - wartosc < 0)
                {
                    predkosc = 0;
                    return true;
                }
            }
            return false;
        }
    }
    public enum Kolor
    {
        Czerwony,
        Czarny,
        Zielony
    }
    class SamochodUzytkowany : Samochod
    {
        public double stanLicznika;
        public Kolor kolor;

        public SamochodUzytkowany(double stanLicznika, Kolor kolor, int rokProdukcji, string marka, double predkoscMax, double predkosc) : base(rokProdukcji, marka, predkoscMax, predkosc)
        {
            this.stanLicznika = stanLicznika;
            this.kolor = kolor;
        }

        public void Pomaluj(Kolor kolor)
        {
            this.kolor = kolor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Samochod s = new Samochod(2020, "BMW", 230, 0);

            s.Wyswietl();
        }
    }
}
