using System;

namespace PD03._01
{
    class Pies
    {
        public string imie;
        public double wiek;
        protected string siersc = "krótka";
        protected string rasa = "kundel";

        public Pies(string imie, double wiek, string siersc, string rasa)
        {
            this.imie = imie;
            this.wiek = wiek;
            this.siersc = siersc;
            this.rasa = rasa;
        }
        public Pies(string imie, double wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Imię: {imie}, Rasa: {rasa}, Sierść: {siersc}, Wiek: {wiek}");
        }
    }
    class Wezel
    {
        public Wezel nastepny;
        public string nagroda;
    }
    class ListaNagrod
    {
        public Wezel glowa;

        public void Dodaj(string nagroda)
        {
            Wezel w = new Wezel();
            w.nagroda = nagroda;
            if (glowa == null)
            {
                glowa = w;
            }
            else
            {
                for (Wezel tmp = glowa; tmp != null; tmp = tmp.nastepny)
                {
                    if (tmp.nastepny == null)
                    {
                        tmp.nastepny = w;
                    }
                }
            }
        }
    }
    class PiesRasowy : Pies
    {
        public ListaNagrod listanagrod;

        public PiesRasowy(string imie, double wiek, string siersc, string rasa) : base(imie, wiek, siersc, rasa)
        {
            this.imie = imie;
            this.wiek = wiek;
            this.siersc = siersc;
            this.rasa = rasa;
        }

        public void DodajNagrode(string nagroda)
        {
            listanagrod.Dodaj(nagroda);
        }
    }
    class Chart : PiesRasowy
    {
        public double predkosc=0;

        public Chart(double predkosc, string imie, double wiek, string siersc, string rasa) : base(imie, wiek, siersc, rasa)
        {
            this.imie = imie;
            this.wiek = wiek;
            this.siersc = siersc;
            this.rasa = rasa;
            this.predkosc = predkosc;
        }

        public void Biegnij()
        {
            predkosc = 15;
        }
        public void Stoj()
        {
            predkosc = 0;
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
