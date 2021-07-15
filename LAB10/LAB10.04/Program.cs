using System;
using System.Collections;
using System.Collections.Generic;

namespace LAB10._04
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
        public string Nazwisko { get { return nazwisko; } }
        public string Stanowisko { get { return stanowisko; } }
        public override string ToString()
        {
            return string.Format("{0} ({1})", nazwisko, stanowisko);
        }
    }
    class MyDefaultEnumerator<T> : IEnumerator
    {
        List<T> brygadaTab;
        int limit;
        public MyDefaultEnumerator(List<T> list)
        {
            this.brygadaTab = list;
            this.limit = list.Count;
        }
        int position = -1;

        public T Current
        {
            get
            {
                if(position > -1 && position < limit)
                {
                    return brygadaTab[position];
                }
                throw new Exception("Something is wrong with this Enumerator...");
            }
        }
        object IEnumerator.Current
        { get { return Current; } }

        public bool MoveNext()
        {
            position++;
            return (position < limit);
        }

        public void Reset()
        {
            position = -1;
        }
    }

    public class MyReverseEnumerator<T> : IEnumerator
    {
        int position;
        int limit;
        List<T> brygadaTab;

        public MyReverseEnumerator(List<T> list)
        {
            this.brygadaTab = list;
            this.position = list.Count;
            this.limit = list.Count;
        }

        public T Current
        {
            get
            {
                if (position > -1 && position < limit)
                {
                    return brygadaTab[position];
                }
                throw new Exception("Something is wrong with this Enumerator");
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            position--;
            return (position > -1);
        }

        public void Reset()
        {
            position = limit;
        }
    }
    class Brygada<T> : IEnumerable
    {
        List<T> brygadaTab;

        public Brygada() { brygadaTab = new List<T>(); }

        public void Add(T t)
        {
            brygadaTab.Add(t);
        }
        public void Remove(T t)
        {
            brygadaTab.Remove(t);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Default Enumerator
        //public MyDefaultEnumerator<T> GetEnumerator()
        //{
        //    return new MyDefaultEnumerator<T>(brygadaTab);
        //}

        //Reverse Enumerator
        public MyReverseEnumerator<T> GetEnumerator()
        {
            return new MyReverseEnumerator<T>(brygadaTab);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Brygada<Pracownik> b1 = new Brygada<Pracownik>();

            Pracownik p1 = new Pracownik("Kowalski", "Programista");
            Pracownik p2 = new Pracownik("Paciaciak", "Księgowy");
            Pracownik p3 = new Pracownik("Nowak", "Sprzątaczka");

            b1.Add(p1);
            b1.Add(p2);
            b1.Add(p3);

            foreach(Pracownik p in b1)
            {
                Console.WriteLine(p);
            }
        }
    }
}
