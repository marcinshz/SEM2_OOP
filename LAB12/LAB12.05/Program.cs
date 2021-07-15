using System;

namespace LAB12._05
{

    public delegate void OP_f(Komputer[] tab, ref int ile);
    public class Komputer
    {
        private double cena;
        private string marka;
        public Komputer(double cena, string marka)
        {
            this.cena = cena;
            this.marka = marka;
        }

        public double Cena
        {
            get { return cena; }
        }

        public string Marka
        {
            get { return marka; }
        }

        public override string ToString()
        {
            return marka + " " + cena;
        }
    }
    class Program
    {
        const int N = 100;

        void Op_N(Komputer[] Tab, ref int ile)
        {
            string str;
            if (ile == N)
            {
                Console.WriteLine("Tablica pełna.");
                return;
            }

            Console.Write("\nPodaj markę komputera : ");
            string m = Console.ReadLine();
            Console.Write("\nPodaj cenę komputera : ");
            str = Console.ReadLine();
            double c = double.Parse(str);
            Tab[ile++] = new Komputer(c, m);
        }

        void Op_W(Komputer[] Tab, ref int ile)
        {
            int licz;
            for (licz = 0; licz < ile; ++licz)
                Console.WriteLine("{0}. M : {1}, C : {2}",
                licz, Tab[licz].Marka, Tab[licz].Cena);
        }

        void Op_U(Komputer[] Tab, ref int ile)
        {
            int licz;
            string str;

            Console.Write("\nPodaj numer komputera : ");
            str = Console.ReadLine();
            licz = int.Parse(str);

            if (licz < 0 || licz >= ile)
            {
                Console.WriteLine("Błędny numer komputera.");
                return;
            }

            Tab[licz] = Tab[ile-- - 1];

        }

        void Op_S(Komputer[] Tab, ref int ile)
        {
            int licz;
            double Suma = 0;
            for (licz = 0; licz < ile; ++licz)
                Suma += Tab[licz].Cena;
            Console.WriteLine("Suma cen wszystkich komputerów : {0}", Suma);
        }

        void Dzialanie()
        {
            Komputer[] TabKomp = new Komputer[N];
            int ile = 0;
            bool dalej = true;
            char opcja;
            string str;

            while (dalej)
            {
                Console.Write("\nWybierz opcję [N,W,U,S,Q] : ");
                str = Console.ReadLine();
                opcja = str[0];

                switch (opcja & 0x5F)
                {
                    case 'N':
                        Op_N(TabKomp, ref ile);
                        break;
                    case 'W':
                        Op_W(TabKomp, ref ile);
                        break;
                    case 'U':
                        Op_U(TabKomp, ref ile);
                        break;
                    case 'S':
                        Op_S(TabKomp, ref ile);
                        break;
                    case 'Q':
                        dalej = false;
                        break;
                    default:
                        Console.WriteLine("Zła opcja");
                        break;
                }


            }

        }
        static void Main(string[] args)
        {
            new Program().Dzialanie();
        }
    }
}
