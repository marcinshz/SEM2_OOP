using System;

namespace LAB01
{
    class Punkt
    {
        double x;
        double y;

        public Punkt()
        {
            this.x = 0;
            this.y = 0;
        }
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Punkt [x={0}; y={1}]", x, y);
        }
        public override string ToString()
        {
            return String.Format("Punkt [x={0}; y={1}]", x, y);
        }
        public void Zmiana(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Przesun(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;
        }
        //zwraca odleglosc od poczatku ukl. wspolrzednych
        public double Odleglosc()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p = new Punkt(1.9, 2.8);
            Console.WriteLine(p);
            p.Zmiana(5, 3);
            Console.WriteLine(p);
        }
    }
}
