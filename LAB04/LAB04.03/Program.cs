using System;

namespace LAB04._03
{
    abstract class Pracownik
    {
        protected string PESEL;
        protected string nazwisko;
        public Pracownik(string PESEL, string nazwisko)
        {
            this.PESEL = PESEL;
            this.nazwisko = nazwisko;
        }
        public abstract float ObliczPlace(float liczbaGodzin);
        public abstract void info();
    }

    class PracownikFizyczny : Pracownik
    {
        protected float stawka;
        public PracownikFizyczny(float stawka, string PESEL, string nazwisko):base(PESEL,nazwisko)
        {
            this.stawka = stawka;
        }
        public override float ObliczPlace(float liczbaGodzin)
        {
            return liczbaGodzin * stawka;
        }
        public override void info()
        {
            Console.WriteLine($"Nazwisko: {nazwisko}, Pesel: {PESEL}, Pracownik fizyczny");
        }
    }
    class PracownikBiurowy : Pracownik
    {
        protected float stawka;
        protected float premia;

        public PracownikBiurowy(float stawka, float premia, string PESEL, string nazwisko) : base(PESEL, nazwisko)
        {
            this.stawka = stawka;
            this.premia = premia;
        }
        public override float ObliczPlace(float liczbaGodzin)
        {
            return (stawka + premia) * liczbaGodzin;
        }
        public override void info()
        {
            Console.WriteLine($"Nazwisko: {nazwisko}, Pesel: {PESEL}, Pracownik biurowy");
        }
    }
    class Kierownik : PracownikBiurowy
    {
        int ilePracownikow;
        public Kierownik(float stawka,float premia,string PESEL, string nazwisko, int ilePracownikow) : base(stawka,premia,PESEL,nazwisko)
        {
            this.ilePracownikow = ilePracownikow;
        }
        public override float ObliczPlace(float liczbaGodzin)
        {
            return (stawka + premia) * ilePracownikow;
        }

        public override void info()
        {
            Console.WriteLine($"Nazwisko: {nazwisko}, Pesel: {PESEL}, Kierownik");
        }
    }
    class Program
    {
        static void ListaPlac(Pracownik[] p, int[] godziny)
        {
            double kwota = 0;
            for (int i = 0; i < p.Length; i++)
            {
                kwota += p[i].ObliczPlace(godziny[i]);
                Console.WriteLine(p[i].ObliczPlace(godziny[i]));
                p[i].info();
                Console.WriteLine();
            }
            Console.WriteLine($"Razem {kwota}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
