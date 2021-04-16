using System;

namespace PD05._02
{
    class Obliczenia
    {
        public static int? Dodaj(int? a, int? b)
        {
            if (a.HasValue && b.HasValue)
            {
                return (int)a + (int)b;
            }
            else if (a.HasValue)
            {
                return (int)a;
            }
            else if (b.HasValue)
            {
                return (int)b;
            }
            else
            {
                return null;
            }
        }

        public static int? Odejmij(int? a, int? b)
        {
            if (a.HasValue && b.HasValue)
            {
                return (int)a - (int)b;
            }
            else if (a.HasValue)
            {
                return (int)a;
            }
            else if (b.HasValue)
            {
                return (int)b;
            }
            else
            {
                return null;
            }
        }

        public static int? Pomnoz(int? a, int? b)
        {
            if (a.HasValue && b.HasValue)
            {
                return (int)a * (int)b;
            }
            else
            {
                return null;
            }
        }

        public static int? Podziel(int? a, int? b)
        {
            if (a.HasValue && b.HasValue && b != 0)
            {
                return (int)a / (int)b;
            }
            else
            {
                return null;
            }
        }

        public static int? Modulo(int? a, int? b)
        {
            if (a.HasValue && b.HasValue)
            {
                return (int)a % (int)b;
            }
            else
            {
                return null;
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(Obliczenia.Dodaj(null, null));
            
        }
    }
}
