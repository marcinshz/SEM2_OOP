using System;

namespace LAB12._01
{
    public delegate void Funkcja(double x);
    class Operacje
    {
        public Funkcja f;
        public static void Podwoj(double x)
        {
            Console.WriteLine(2 * x);
        }
        public static void Sinus(double x)
        {
            Console.WriteLine(Math.Sin(x));
        }
        public static void Kwadrat(double x)
        {
            Console.WriteLine(Math.Pow(x,2));
        }
    }
    class Program
    {
        static void Calkowita(double x)
        {
            Console.WriteLine((int)x);
        }
        static void Main(string[] args)
        {
            Operacje o = new Operacje();
            o.f = Calkowita;
            o.f(5.5);

            Console.WriteLine();

            Funkcja wiele;
            wiele = Calkowita;
            wiele += Operacje.Podwoj;
            wiele += Operacje.Sinus;
            wiele += Operacje.Kwadrat;

            wiele(2.5);
        }
    }
}
