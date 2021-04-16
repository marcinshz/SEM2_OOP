using System;

namespace PD02._01
{
    class Macierz
    {
        //a - wiersz pierwszy
        //b - wiersz drugi
        //1 - kolumna pierwsza
        //2 - kolumna druga

        public double a1, a2, b1, b2;

        public Macierz(double a1, double a2, double b1, double b2)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.b1 = b1;
            this.b2 = b2;
        }
        public static void WyswietlMacierz(Macierz M)
        {
            Console.WriteLine($" {M.a1}  {M.a2}");
            Console.WriteLine($" {M.b1}  {M.b2}");
        }
        public static Macierz PomnozPrzezStala(double stala, Macierz M)
        {
            M.a1 = M.a1 * stala;
            M.a2 = M.a2 * stala;
            M.b1 = M.b1 * stala;
            M.b2 = M.b2 * stala;

            return M;
        }
        public static Macierz DodajMacierze(Macierz M1, Macierz M2)
        {
            double a1 = M1.a1 + M2.a1;
            double a2 = M1.a2 + M2.a2;
            double b1 = M1.b1 + M2.b1;
            double b2 = M1.b2 + M2.b2;

            Macierz Wynik = new Macierz(a1, a2, b1, b2);
            return Wynik;
        }

        public static Macierz MnozenieMacierzy(Macierz M1, Macierz M2)
        {
            double a1 = (M1.a1 * M2.a1) + (M1.a2 * M2.b1);
            double a2 = (M1.a1 * M2.a2) + (M1.a2 * M2.b2);
            double b1 = (M1.b1 * M2.a1) + (M1.b2 * M2.b1);
            double b2 = (M1.b1 * M2.a2) + (M1.b2 * M2.b2);

            Macierz Wynik = new Macierz(a1, a2, b1, b2);
            return Wynik;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Macierz M1 = new Macierz(5, 3, 2, 1);
            Macierz M2 = new Macierz(2, 4, 7, 3);
            Macierz.WyswietlMacierz(M1);
            Console.WriteLine();
            Macierz.WyswietlMacierz(M2);
            Console.WriteLine();
            Macierz M3 = Macierz.MnozenieMacierzy(M1, M2);
            Macierz.WyswietlMacierz(M3);
        }
    }
}
