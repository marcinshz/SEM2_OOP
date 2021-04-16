using System;

namespace LAB05._03
{
    class ZbiorZapisow
    {
        Zapis glowa;

        class Zapis
        {
            string opis;
            DateTime d;
            Zapis nastepny;
            public Zapis(string opis)
            {
                this.opis = opis;
                d = DateTime.Now;
            }
            public void Dodaj(string s)
            {
                Zapis z = new Zapis(s);
                Zapis tmp = this;
                while(tmp.nastepny != null)
                {
                    tmp = tmp.nastepny;
                }
                tmp.nastepny = z;
            }
            public void Wypisz()
            {
                Zapis tmp = this;
                while(tmp != null)
                {
                    Console.WriteLine(tmp.opis + " " + d.Hour);
                }
            }
        }

        public void DodajZapis(string s)
        {
            Zapis z = new Zapis(s);
            if (glowa == null)
            {
                glowa = z;
            }
            else
            {
                glowa.Dodaj(s);
            }
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
