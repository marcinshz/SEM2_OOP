using System;
using System.Collections.Generic;

namespace LAB09._01
{
    class Porównanie : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return ((x % 2) - (y % 2));
        }
    }
    class Program
    {
        public static int Zliczaj<T>(T[] tablica, T wartosc) where T:IComparable<T>
        {
            int n = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if(tablica[i].CompareTo(wartosc) == 0)
                {
                    n++;
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            int[] t = { 5, 3, 24, 1, 5, 7, 24 };
            Console.WriteLine(Zliczaj(t,5));
            Console.WriteLine(Zliczaj(t,7));
        }
    }
}
