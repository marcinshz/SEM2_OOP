using System;

namespace LAB05._01
{
    class Tablica
    {
        private double[] tablica;
        public Tablica(int n)
        {
            tablica = new double[n];
        }
        public double this[int index]
        {
            get { return tablica[index]; }
            set { tablica[index] = value; }
        }
        public int rozmiar
        {
            get { return tablica.Length; }
        }
        public void Wypisz()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }
        public int Wyszukaj(double d)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == d)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tablica t = new Tablica(10);
            t[1] = 2.1;
            t[4] = 4.6;
            t.Wypisz();

        }
    }
}
