using System;

namespace PD03._02
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public string plec;

        public Osoba(string imie, string nazwisko, int rokUrodzenia, string plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.plec = plec;
        }
    }
    class Wykladowca : Osoba
    {
        public string tytulNaukowy;
        public Wykladowca(string imie, string nazwisko, int rokUrodzenia, string plec, string tytulNaukowy) : base(imie, nazwisko, rokUrodzenia, plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.plec = plec;
            this.tytulNaukowy = tytulNaukowy;
        }
    }
    class Student : Osoba
    {
        public int numerIndeksu;
        public Student(string imie, string nazwisko, int rokUrodzenia, string plec, int numerIndeksu) : base(imie, nazwisko, rokUrodzenia, plec)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.plec = plec;
            this.numerIndeksu = numerIndeksu;
        }
    }
    class Stypendysta : Student
    {
        public double kwotaStypendium;
        public Stypendysta(string imie, string nazwisko, int rokUrodzenia, string plec, int numerIndeksu, int kwotaStypendium) : base(imie, nazwisko, rokUrodzenia, plec, numerIndeksu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.plec = plec;
            this.numerIndeksu = numerIndeksu;
            this.kwotaStypendium = kwotaStypendium;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
