using System;
namespace PD1
{
    class Zespolona
    {
        public double x;
        public double y;

        public Zespolona(double czRzeczywista, double czUrojona)
        {
            this.x = czRzeczywista;
            this.y = czUrojona;
        }
        public void WyswietlWspolrzedne()
        {
            Console.WriteLine($"({x};{y})");
        }
        //a - cz. rzeczywista liczby zespolonej przez którą mnożymy
        //b - cz. urojona liczby zespolonej przez którą mnożymy
        public void Dodaj(double a, double b)
        {
            this.x += a;
            this.y += b;
        }
        public void Odejmij(double a, double b)
        {
            this.x -= a;
            this.y -= b;
        }
        public void Pomnoz(double a, double b)
        {
            double tmpx = x;
            double tmpy = y;
            this.x = ((tmpx * a) - (tmpy * b));
            this.y = ((tmpx * b) + (tmpy * a));
        }
        public void Podziel(double a, double b)
        {
            double tmpx = x;
            double tmpy = y;
            this.x = ((tmpx * a + tmpy * b) / ((a * a) + (b * b)));
            this.y = ((a * tmpy - b * tmpx) / ((a * a) + (b * b)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zespolona z1 = new Zespolona(2, 3);
            z1.WyswietlWspolrzedne();
            z1.Pomnoz(5, 6);
            z1.WyswietlWspolrzedne();
            z1.Podziel(5, 6);
            z1.WyswietlWspolrzedne();
        }
    }
}
