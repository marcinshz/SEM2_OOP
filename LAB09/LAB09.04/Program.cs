using System;
using System.Collections.Generic;

namespace LAB09._04
{
    class Kolejka<T>
    {
        List<T> elementy = new List<T>();

        public void Dodaj(T nowy)
        {
            elementy.Add(nowy);
        }

        public T Podejrzyj()
        {
            return elementy[0];
        }

        public bool CzyPusta()
        {
            return elementy.Count == 0;
        }

        public T Usun()
        {
            T element = elementy[0];
            elementy.RemoveAt(0);
            return element;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kolejka<int> k1 = new Kolejka<int>();
            k1.Dodaj(5);
            k1.Dodaj(4);
            k1.Dodaj(9);
            k1.Dodaj(7);
            Console.WriteLine(k1.Podejrzyj());
            k1.Dodaj(11);
            Console.WriteLine(k1.Usun());
            while(!k1.CzyPusta())
            {
                Console.WriteLine(k1.Usun());
            }
        }
    }
}
