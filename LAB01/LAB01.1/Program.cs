using System;

namespace LAB01._1
{
    class Student
    {
        string imie;
        string nazwisko;
        int nrAlbumu;
        int semestr;
        public Student(string imie, string nazwisko, int nrAlbumu, int semestr)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nrAlbumu = nrAlbumu;
            this.semestr = semestr;
        }

        public bool NadajNumer(int nrAlbumu)
        {
            if (semestr == 0)
            {
                this.nrAlbumu = nrAlbumu;
                this.semestr = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Wyswietl()
        {
            if (semestr == 0)
            {
                Console.WriteLine("Kandydat: " + nazwisko + " " + imie);
            }
            if (semestr == 8)
            {
                Console.WriteLine("Absolwent: " + nazwisko + " " + imie + " " + nrAlbumu);
            }
            else
            {
                Console.WriteLine("Student: " + nazwisko + " " + imie + " " + nrAlbumu + " " + semestr);
            }

        }
        public void ZmienImie(string noweImie)
        {
            this.imie = noweImie;
        }
        public void ZmienNazwisko(string noweNazwisko)
        {
            this.nazwisko = noweNazwisko;
        }
        public void Awans()
        {
            if (semestr < 8)
            {
                semestr++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
