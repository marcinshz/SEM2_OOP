using System;

namespace LAB02
{
    struct Zespolona
    {
        //z = a + ib
        //a - czesc rzeczywista
        //b - czesc urojona
        public double a;
        public double b;

        public Zespolona(double czescRzeczywista, double czescUrojona)
        {
            this.a = czescRzeczywista;
            this.b = czescUrojona;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Współrzędne liczby zespolonej: ({a}; {b}).");
        }

        public static Zespolona Dodaj(Zespolona x, Zespolona y)
        {
            double wynikR = x.a + y.a;
            double wynikU = x.b + y.b;
            Zespolona wynik = new Zespolona(wynikR, wynikU);
            return wynik;
        }

        public static Zespolona Odejmij(Zespolona x, Zespolona y)
        {
            double wynikR = x.a - y.a;
            double wynikU = x.b - y.b;
            Zespolona wynik = new Zespolona(wynikR, wynikU);
            return wynik;
        }

        public static Zespolona Pomnoz(Zespolona x, Zespolona y)
        {
            double wynikR = x.a * y.a - x.b * y.b;
            double wynikU = x.a * y.b + x.b * y.a;
            Zespolona wynik = new Zespolona(wynikR, wynikU);
            return wynik;
        }

        public static Zespolona Podziel(Zespolona x, Zespolona y)
        {
            double wynikR = (x.a * y.a + x.b * y.b) / (y.a * y.a + y.b * y.b);
            double wynikU = (x.b * y.a - x.a * y.b) / (y.a * y.a + y.b * y.b);
            Zespolona wynik = new Zespolona(wynikR, wynikU);
            return wynik;
        }

        //set pozwala nam zmienic wartosc
        public double Re
        {
            get { return a; }
            set { a = value; }
        }
        public double Imag
        {
            get { return b; }
            set { b = value; }
        }
        public Zespolona Sprzezona()
        {
            return new Zespolona(a, -b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zespolona z1 = new Zespolona(1, 2);
            Zespolona z2 = new Zespolona(3, 4);
            Zespolona z3 = Zespolona.Dodaj(z1, z2);
            Console.WriteLine(z3.Re);
            Console.WriteLine(z3.Imag);
        }
    }
}
