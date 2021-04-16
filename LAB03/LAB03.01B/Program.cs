using System;

namespace LAB03._01B
{
    struct Punkt
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Przesun(double d, double f)
        {
            x += d;
            y += f;
        }
        public void Wyswietl()
        {
            Console.WriteLine(x + " " + y);
        }

        // niestatyczne
        public double Odleglosc(Punkt p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }

        public bool CzyIdentyczny(Punkt p)
        {
            return (x == p.x) && (y == p.y);
        }

        // statyczne, wykorzystujace juz zdefiniowane metody zwykle
        public static double Odleglosc(Punkt p1, Punkt p2)
        {
            return p1.Odleglosc(p2);
        }

        public static bool CzyIdentyczne(Punkt p, Punkt q)
        {
            return q.CzyIdentyczny(p);
        }
    }
    struct Kolorowy
    {
        Punkt p;
        string kolor;

        public Kolorowy(double x, double y, string kolor)
        {
            this.p = new Punkt(x, y);
            this.kolor = kolor;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Punkt o kolorze {kolor}");
            p.Wyswietl();
        }

        public Punkt P
        {
            get { return p; }
        }
        public double Odleglosc(Punkt p)
        {
            return this.p.Odleglosc(p);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kolorowy k = new Kolorowy();
            Punkt p = new Punkt(2, 2);
            p.Wyswietl();
            Console.WriteLine(p.Odleglosc(p));
        }
    }
}
