using System;
using System.Collections;
using System.Collections.Generic;

namespace LAB10._02
{
    public class Osoba
    {
        string nazwisko;

        public Osoba(string n)
        {
            this.nazwisko = n;
        }
        public string Nazwisko { get { return nazwisko; } }
        public override string ToString()
        {
            return $"{Nazwisko}";
        }
    }
    public class Pracownik
    {
        string nazwisko;
        string stanowisko;

        public Pracownik(string nazwisko, string stanowisko)
        {
            this.nazwisko = nazwisko;
            this.stanowisko = stanowisko;
        }
        public string Stanowisko { get { return stanowisko; } }
        public override string ToString()
        {
            return string.Format("{0} ({1})", nazwisko, stanowisko);
        }
    }
    public class Firma<T> : IEnumerable<T>
    {
        string nazwa;
        private List<T> pracownicy;

        public Firma(string nazwa)
        {
            this.nazwa = nazwa;
            this.pracownicy = new List<T>();
        }
        public void DodajPracownika(T p)
        {
            pracownicy.Add(p);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return pracownicy.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma<Pracownik> f1 = new Firma<Pracownik>("WASKI COMPANY");

            Pracownik p1 = new Pracownik("Kowalski", "Programista");
            Pracownik p2 = new Pracownik("Paciaciak", "Księgowy");
            Pracownik p3 = new Pracownik("Nowak", "Sprzątaczka");

            f1.DodajPracownika(p1);
            f1.DodajPracownika(p2);
            f1.DodajPracownika(p3);

            foreach(Pracownik p in f1)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Firma<Osoba> f2 = new Firma<Osoba>("SZEROKI COMPANY");

            Osoba o1 = new Osoba("Solejuk");
            Osoba o2 = new Osoba("Rutkowski");

            f2.DodajPracownika(o1);
            f2.DodajPracownika(o2);

            foreach (Osoba o in f2)
            {
                Console.WriteLine(o);
            }
        }
    }
}
