using System;
using LAB08._04.Firma;

namespace LAB08._04
{
    class Program
    {
        public static string Menu()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine();
            Console.WriteLine("N - Nowy pracownik");
            Console.WriteLine("P - Zmiana pensji pracownika");
            Console.WriteLine("R - Zmiana premii pracownika");
            Console.WriteLine("W - Suma wszystkich wypłat");
            Console.WriteLine("K - Koniec");

            string opcja = Console.ReadLine();
            return opcja;
        }
        public static Pracownik N()
        {
            Console.WriteLine("Podaj nazwisko pracownika");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Wpisz pensję pracownia");
            double pensja = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wpisz premię pracownika");
            double premia = Convert.ToDouble(Console.ReadLine());
            Pracownik p = new Pracownik(nazwisko, pensja, premia);
            return p;
        }
        public static void P(ref Firma.Firma f)
        {
            Console.WriteLine("Podaj nazwisko pracownika");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj nową pensję");
            double pensja = Convert.ToDouble(Console.ReadLine());
            f.ZmienPensje(nazwisko, pensja);
        }
        public static void R(ref Firma.Firma f)
        {
            Console.WriteLine("Podaj nazwisko pracownika");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj nową pensję");
            double premia = Convert.ToDouble(Console.ReadLine());
            f.ZmienPremie(nazwisko, premia);
        }
        
        
        public static void Start()
        {
            Firma.Firma f1 = new Firma.Firma(10);
            string opcja = Menu();
            switch (opcja)
            {
                case "N":
                    f1.DodajPracownika(N());
                    Start();
                    break;
                case "P":
                    P(ref f1);
                    Start();
                    break;
                case "R":
                    R(ref f1);
                    Start();
                    break;
                case "W":
                    Console.WriteLine($"Suma wszystkich wypłat wynosi {f1.Wyplata()}");
                    Start();
                    break;
                case "K":
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Zła litera!");
                    Start();
                    break;

            }

        }
        static void Main(string[] args)
        {
            Start();
        }

    }
}
