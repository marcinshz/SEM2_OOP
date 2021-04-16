using System;

namespace PD05._01
{
    class Europe
    {
        double[] koordynatyx = { 52.2, 52.3, 45.5, 54.0, 48.13, 41.54, 52.1, 59.23, 41.52, 50.05, 48.51, 40.26, 49.37, 51.03 };
        double[] koordynatyy = { 4.5, 13.0, 15.58, 25.19, 16.22, 12.27, 21.0, 18.0, 12.37, 14.25, 2.02, 3.42, 6.08, 0.01 };
        string[] stolice = { "Amsterdam", "Berlin", "Zagrzeb", "Wilno", "Wiedeń", "Watykan", "Warszawa", "Sztokholm",
        "Rzym", "Praga", "Paryż", "Madryt", "Luksemburg", "Londyn" };
        public Europe()
        { }

        public int znajdzNajblizsza(double x, double y)
        {
            int indeks = 0;
            double odleglosc = Math.Sqrt(Math.Pow(x-koordynatyx[0],2) + Math.Pow(y-koordynatyy[0],2));
            for (int i = 1; i < koordynatyx.Length; i++)
            {
                if(Math.Abs(Math.Sqrt(Math.Pow(x - koordynatyx[i], 2) + Math.Pow(y - koordynatyy[i], 2))) < odleglosc)
                {
                    odleglosc = Math.Sqrt(Math.Pow(x - koordynatyx[i], 2) + Math.Pow(y - koordynatyy[i], 2));
                    indeks = i;
                }
            }
            return indeks;
            
        }
        public string this[double x, double y]
        {
            get { return stolice[znajdzNajblizsza(x, y)]; }
        }
    }
    class Coordinates
    {
        double[] koordynatyx = { 52.2, 52.3, 45.5, 54.0, 48.13, 41.54, 52.1, 59.23, 41.52, 50.05, 48.51, 40.26, 49.37, 51.03 };
        double[] koordynatyy = { 4.5, 13.0, 15.58, 25.19, 16.22, 12.27, 21.0, 18.0, 12.37, 14.25, 2.02, 3.42, 6.08, 0.01 };
        string[] stolice = { "Amsterdam", "Berlin", "Zagrzeb", "Wilno", "Wiedeń", "Watykan", "Warszawa", "Sztokholm",
        "Rzym", "Praga", "Paryż", "Madryt", "Luksemburg", "Londyn" };
        public Coordinates()
        { }

        public string zwrocKordy(string nazwa)
        {
            string kordy = "";
            for (int i = 0; i < stolice.Length; i++)
            {
                if (nazwa == stolice[i])
                {
                    kordy = $"{koordynatyx[i]}, {koordynatyy[i]}";
                }
            }
            return kordy;
        }
        public string this[string nazwa]
        {
            get { return zwrocKordy(nazwa); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Europe EU = new Europe();
            string nazwa = EU[50, 20];
            Console.WriteLine(nazwa);

            Coordinates EUkordy = new Coordinates();
            string kordy = EUkordy["Watykan"];
            Console.WriteLine(kordy);
        }
    }
}
