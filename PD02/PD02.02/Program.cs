using System;

namespace PD02._02
{
    static class Rozszerzenie
    {
        public static double Dodaj(this double x, double y)
        {
            return x + y;
        }
        public static double Odejmij(this double x, double y)
        {
            return x - y;
        }
        public static double Sinus(this double x)
        {
            //Korzystam z rozwiniecia w szereg Taylora piatej potegi
            //x musi byc podane w radianach nie w stopniach
            double sinus = (x - ((x.Potegowanie(3)) / 6) + ((x.Potegowanie(5)) / 120) - ((x.Potegowanie(7))/5040));
            return sinus;
        }
        public static double Potegowanie(this double x, double stopien)
        {
            double tmp = x;
            if (stopien > 1)
            {
                for (int i = 1; i < stopien; i++)
                {
                    x = x * tmp;
                }
                return x;
            }
            if (stopien == 1)
            {
                return x;
            }
            if (stopien == 0)
            {
                return 1;
            }
            else
            {
                stopien = stopien * (-1);
                for (int i = 1; i < stopien; i++)
                {
                    x = x * tmp;
                }
                return 1 / x;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
