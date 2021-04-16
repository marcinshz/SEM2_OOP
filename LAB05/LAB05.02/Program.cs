using System;

namespace LAB05._02
{
    class Operacje
    {
        public static int? Silnia(int n)
        {
            if (n < 0 || n > 12)
            {
                return null;
            }
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik *= i;
            }
            return wynik;
        }
        public static int? PierwiastekKwadratowy(int n)
        {
            if (n < 0)
            {
                return null;
            }
            int wynik = (int) Math.Sqrt(n);
            return wynik;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int? wynik = Operacje.Silnia(15);
            wynik = Operacje.Silnia(5);
            if (!wynik.HasValue)
            {
                Console.WriteLine("Działanie niewykonalne");
            }
            else
            {
                Console.WriteLine(wynik);
            }

            int? wynik2 = Operacje.PierwiastekKwadratowy(-5);
            if(wynik2.HasValue)
            {
                Console.WriteLine(wynik2);
            }
            else
            {
                Console.WriteLine("Działanie niewykonalne");
            }
        }
    }
}
