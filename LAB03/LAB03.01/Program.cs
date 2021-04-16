using System;

namespace LAB03._01
{
    class Punkt
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
        public Punkt()
            : this(0, 0)
        {

        }
        public void Przesun(double d, double f)
        {
            x += d;
            y += f;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"({x},{y})");
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

        // statyczne, wykorzystujace juz zdefiniowane metody niestatyczne
        public static double Odleglosc(Punkt p1, Punkt p2)
        {
            return p1.Odleglosc(p2);
        }

        public static bool CzyIdentyczne(Punkt p, Punkt q)
        {
            return q.CzyIdentyczny(p);
        }
    }

    class PunktKolorowy : Punkt
    {
        private string kolor;

        public PunktKolorowy(double x, double y, string kolor) : base(x, y)
        {
            this.kolor = kolor;
        }
        public PunktKolorowy(string kolor)
        {
            this.kolor = kolor;
        }
        public PunktKolorowy() : this("czarny")
        { }

        public new void Wyswietl()
        {
            Console.WriteLine($"Punkt w kolorze {kolor}");
            base.Wyswietl();
        }
        public string Kolor
        {
            get { return kolor; }
        }
    }

    class PunktKolorowyOpisany : PunktKolorowy
    {
        private string opis;

        public PunktKolorowyOpisany(double x, double y, string kolor, string opis) : base(x, y, kolor)
        {
            this.opis = opis;
        }

        public new void Wyswietl()
        {
            base.Wyswietl();
            Console.WriteLine(opis);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Punkt r = new Punkt();
            Punkt p = new Punkt(1, 4);
            PunktKolorowyOpisany s = new PunktKolorowyOpisany(2, 4, "zielony", "wierzchołek");
            s.Wyswietl();
            Console.ReadKey();
        }
    }
}
