using System;

namespace PD05._03
{
    enum typOperacji
    {
        wplata,
        wyplata
    }
    class Konto
    {
        protected int nrKonta;
        protected double stanKonta;
        ListaOperacji LO = new ListaOperacji();
        public Konto(int nrKonta, double stanKonta)
        {
            this.nrKonta = nrKonta;
            this.stanKonta = stanKonta;
        }
        public void Wyplata(double kwota, DateTime data)
        {
            if (kwota <= stanKonta)
            {
                stanKonta -= kwota;
                Operacja o = new Operacja(data, kwota, typOperacji.wyplata);
                LO.dodajOperacje(o);
            }
            else
            {
                Console.WriteLine("Nie masz tyle pieniędzy na koncie");
            }
        }
        public void Wplata(double kwota, DateTime data)
        {
            stanKonta += kwota;
            Operacja o = new Operacja(data, kwota, typOperacji.wplata);
            LO.dodajOperacje(o);
        }
        public void WyswietlWszystkieOperacje()
        {
            for (int i = 0; i < LO.lista.Length; i++)
            {
                LO.lista[i].wyswietlOperacje();
                Console.WriteLine();
                Console.WriteLine("/////////////////////////////////////");
                Console.WriteLine();
            }
        }
        class Operacja
        {
            readonly DateTime data = new DateTime();
            readonly double kwota;
            readonly typOperacji typ;

            public Operacja(DateTime data, double kwota, typOperacji typ)
            {
                this.data = data;
                this.kwota = kwota;
                this.typ = typ;
            }
            public void wyswietlOperacje()
            {
                Console.WriteLine($"Typ operacji: {typ}");
                Console.WriteLine($"Kwota: {kwota}");
                Console.WriteLine($"Data: {data}");
            }
        }
        class ListaOperacji
        {
            public Operacja[] lista = new Operacja[1];
            public ListaOperacji()
            {
            }

            public void dodajOperacje(Operacja o)
            {
                if(lista[0] == null)
                {
                    lista[0] = o;
                }
                else
                {
                    Array.Resize(ref lista, lista.Length + 1);
                    lista[lista.Length - 1] = o;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto(123456789, 500);
            DateTime data1 = new DateTime(2021, 4, 2, 8, 42, 20);
            DateTime data2 = new DateTime(2021, 4, 4, 13, 20, 10);
            DateTime data3 = new DateTime(2021, 4, 5, 18, 56, 00);
            k1.Wplata(300, data1);
            k1.Wyplata(400, data2);
            k1.Wplata(1050.3, data3);
            k1.WyswietlWszystkieOperacje();
            Console.WriteLine();

        }
    }
}
