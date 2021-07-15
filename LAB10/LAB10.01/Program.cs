using System;
using System.Collections;

namespace LAB10._01
{
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
    public class Firma : IEnumerable
    {
        string nazwa;
        private Pracownik[] pracownicy;

        public Firma(string nazwa, int liczbaPracownikow)
        {
            this.nazwa = nazwa;
            this.pracownicy = new Pracownik[liczbaPracownikow];
        }
        public void DodajPracownika(Pracownik p)
        {
            for (int i = 0; i < pracownicy.Length; i++)
            {
                if (pracownicy[i] == null)
                {
                    pracownicy[i] = p;
                    return;
                }
            }
            Console.WriteLine("Nie ma miejsca na kolejnego pracownika!");
        }
        public IEnumerator GetEnumerator()
        {
            return pracownicy.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma f1 = new Firma("WASKI COMPANY", 3);

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
        }
    }
}
