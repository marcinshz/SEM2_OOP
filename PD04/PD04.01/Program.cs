using System;

namespace PD04._01
{
    abstract class Osoba
    {
        public string imie, nazwisko;
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public abstract void Wyswietl();
    }
    class Uczen : Osoba
    {
        int rocznik;
        int klasa;

        public Uczen(int rocznik, int klasa, string imie, string nazwisko) : base(imie,nazwisko)
        {
            this.rocznik = rocznik;
            this.klasa = klasa;
        }

        public override void Wyswietl()
        {
            Console.WriteLine($"{imie} {nazwisko} {rocznik} {klasa}");
        }
    }
    class Student : Osoba
    {
        public string kierunek;

        public Student(string kierunek, string imie, string nazwisko) : base(imie, nazwisko)
        {
            this.kierunek = kierunek;
        }

        public override void Wyswietl()
        {
            Console.WriteLine($"{imie} {nazwisko} {kierunek}");
        }
    }

    class Emeryt : Osoba
    {
        protected double wysokoscEmerytury;
        public Emeryt(double wysokoscEmerytury, string imie, string nazwisko) : base(imie,nazwisko)
        {
            this.wysokoscEmerytury = wysokoscEmerytury;
        }

        public override void Wyswietl()
        {
            Console.WriteLine($"{imie} {nazwisko} emeryt");
        }
    }
    class Program
    {
        static void WyswietlOsoby(Osoba[] osoby)
        {
            for (int i = 0; i < osoby.Length; i++)
            {
                osoby[i].Wyswietl();
            }
        }
        static void Main(string[] args)
        {
            Uczen u1 = new Uczen(2001, 5, "Jimmy", "Łysy");
            Student s1 = new Student("informatyka", "Marcin", "Chodkowski");
            Emeryt e1 = new Emeryt(1000, "Karol", "Załęski");
            Osoba[] osoby = { u1, s1, e1 };
            WyswietlOsoby(osoby);
        }
    }
}
