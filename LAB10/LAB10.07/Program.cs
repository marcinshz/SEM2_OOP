using System;
using System.Collections;
using System.Collections.Generic;

namespace LAB10._07
{
    public class Pracownik : IComparable
    {
        string nazwisko;
        string stanowisko;

        public Pracownik(string nazwisko, string stanowisko)
        {
            this.nazwisko = nazwisko;
            this.stanowisko = stanowisko;
        }
        public string Nazwisko { get { return nazwisko; } }
        public string Stanowisko { get { return stanowisko; } }

        public int CompareTo(object obj)
        {
            Pracownik p = (Pracownik)obj;
            return nazwisko.CompareTo(p.nazwisko);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", nazwisko, stanowisko);
        }
    }
    class Brygada<T> : IEnumerable
    {
        public List<T> brygadaTab;

        public Brygada() { brygadaTab = new List<T>(); }

        public void Add(T t)
        {
            brygadaTab.Add(t);
        }
        public T this[int index]
        {
            get { return brygadaTab[index]; }
            set { brygadaTab[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            return brygadaTab.GetEnumerator();
        }

        public void Remove(T t)
        {
            brygadaTab.Remove(t);
        }
    }
    class Program
    {
        static int Zlicz<T>(List<T> l, T value) where T:IComparable//<T>
        {
            int counter = 0;
            foreach(T item in l)
            {
                if (item.CompareTo(value) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik("Kowalski", "Programista");
            Pracownik p2 = new Pracownik("Paciaciak", "Księgowy");
            Pracownik p3 = new Pracownik("Nowak", "Sprzątaczka");

            Brygada<Pracownik> b1 = new Brygada<Pracownik>();
            b1.Add(p1);
            b1.Add(p2);
            b1.Add(p3);

            Console.WriteLine(Zlicz<Pracownik>(b1.brygadaTab, p3)); 
        }
    }
}
