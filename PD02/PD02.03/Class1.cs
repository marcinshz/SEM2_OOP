using System;

namespace PD02._03
{
    static class Biblioteka
    {
        public static float Ilosc
        {
            get;
            set;
        }
        public static float IloscTuzin
        {
            set { Ilosc = value * 12; }
            get { return Ilosc / 12; }
        }
        public static float IloscMendel
        {
            set { Ilosc = value * 15; }
            get { return Ilosc / 15; }
        }
        public static float IloscKopa
        {
            set { Ilosc = value * 60; }
            get { return Ilosc / 60; }
        }


        public static double Dlugosc
        {
            get;
            set;
        }
        public static double DlugoscMm
        {
            set { Dlugosc = value * 1000; }
            get { return Dlugosc / 1000; }
        }
        public static double DlugoscCale
        {
            set { Dlugosc = value * 0.0254; }
            get { return Dlugosc / 0.0254; }
        }
        public static double DlugoscJard
        {
            set { Dlugosc = value * 0.9144; }
            get { return Dlugosc / 0.9144; }
        }
        public static double DlugoscMilaMorska
        {
            set { Dlugosc = value * 1852; }
            get { return Dlugosc / 1852; }
        }
        public static double DlugoscMilaAngielska
        {
            set { Dlugosc = value * 1609.344; }
            get { return Dlugosc / 1609.344; }
        }
        public static double Masa { get; set; }

        public static double MasaGramy
        {
            set { Masa = value / 1000; }
            get { return Masa * 1000; }
        }
        public static double MasaTona
        {
            set { Masa = value * 1000; }
            get { return Masa / 1000; }
        }
        public static double MasaKwintal
        {
            set { Masa = value * 100; }
            get { return Masa / 100; }
        }
        public static double MasaFuntBryt
        {
            set { Masa = value / 0.453592; }
            get { return Masa * 0453592; }
        }

        public static double MasaUncja
        {
            set { Masa = (value / 1000) / 28.35; }
            get { return Masa * 1000 * 28.35; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
