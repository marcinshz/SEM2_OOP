using System;
/*Zadanie 5 (do domu)
Napisać prostą klasę symulującą prosty kalkulator (wystarczą cztery działania i możliwość zapisu wyniku do pamięci).*/
namespace PD1._2
{
    class Kalkulator
    {
        public double wynik;
        
        public double Dodaj(double x, double y)
        {
            this.wynik = x + y;
            return x + y;
        }
        public double Odejmij(double x, double y)
        {
            this.wynik = x - y;
            return x - y;
        }
        public double Pomnoz(double x, double y)
        {
            this.wynik = x * y;
            return x * y;
        }
        public double PodniesDoPotegi(double x, int potega)
        {
            double wynik = x;
            for (int i = 1; i < potega; i++)
            {
                wynik = wynik * x;
            }
            this.wynik = wynik;
            return wynik;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k1 = new Kalkulator();
            Console.WriteLine(k1.PodniesDoPotegi(3, 4));
        }
    }
}
