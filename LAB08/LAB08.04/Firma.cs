using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB08._04.Firma
{
    class Firma
    {
        Pracownik[] pracownicy;

        public Firma(int liczbaPracownikow)
        {
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
            Console.WriteLine("Nie można dodać więcej pracowników!");
        }
        public void ZmienPremie(string nazwisko, double premia)
        {
            for (int i = 0; i < pracownicy.Length; i++)
            {
                if (pracownicy[i].nazwisko == nazwisko)
                {
                    pracownicy[i].procentPremii = premia;
                    return;
                }
            }
            Console.WriteLine("Nie ma takiego pracownika!");
        }

        public void ZmienPensje(string nazwisko, double pensja)
        {
            for (int i = 0; i < pracownicy.Length; i++)
            {
                if (pracownicy[i].nazwisko == nazwisko)
                {
                    pracownicy[i].pensja = pensja;
                    return;
                }
            }
            Console.WriteLine("Nie ma takiego pracownika!");
        }

        public double Wyplata()
        {
            double suma = 0;
            for (int i = 0; i < pracownicy.Length; i++)
            {
                suma += pracownicy[i].Wyplata();
            }
            return suma;
        }
    }
}
