using System;

namespace LAB12._03
{
    public delegate double Funkcja(double x);
    public delegate double Metoda(Funkcja f, double a, double b);
    class Calka
    {
        public static double CalkujTrapez(Funkcja f, double a, double b)
        {
            return ((f(a) + f(b)) / 2) * (b - a);
        }
        public static double CalkujProstokat(Funkcja f, double a, double b)
        {
            return f((a + b) / 2) * (b - a);
        }
        public static double Calkuj(Metoda m, Funkcja f, double a, double b)
        {
            return m(f, a, b);
        }
    }
    class Program
    {
        public static double Kwadrat(double x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            double wynik1 = Calka.Calkuj(Calka.CalkujProstokat, Kwadrat, 5, 9);
            Console.WriteLine(wynik1);

            double wynik2 = Calka.Calkuj(Calka.CalkujTrapez, Math.Sin, 2, 9);
            Console.WriteLine(wynik2);
        }
    }
}
