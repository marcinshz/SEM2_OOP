using System;
using System.Collections;
using System.Collections.Generic;

namespace LAB10._03
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
    public class GrupaPracownikow : IEnumerable
    {
        List<Pracownik> grupa;

        public GrupaPracownikow() 
        {
            grupa = new List<Pracownik>();         
        }

        public void DodajPracownika(Pracownik p)
        {
            grupa.Add(p);
        }
        public void UsunPracownika(Pracownik p)
        {
            grupa.Remove(p);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        //Enumerator standardowy

        //public IEnumerator<Pracownik> GetEnumerator()
        //{
        //    return grupa.GetEnumerator();
        //}


        //Enumerator odwrotny
        public OdwrotnyEnumerator GetEnumerator()
        {
            return new OdwrotnyEnumerator(grupa);
        }


        //Enumerator odwrotny
        public class OdwrotnyEnumerator : IEnumerator
        {
            public List<Pracownik> grupa;
            public int defPos;
            public int position;
            public OdwrotnyEnumerator(List<Pracownik> list)
            {
                this.grupa = list;
                this.position = list.Count;
                this.defPos = list.Count;
            }
            public bool MoveNext()
            {
                position--;
                return (position > -1);
            }

            public void Reset()
            {
                position = defPos;
            }
            object IEnumerator.Current
            {
                get { return Current; }
            }

            public Pracownik Current
            {
                get
                {
                    if (position >= 0 && position < grupa.Count)
                    {
                        return grupa[position];
                    }
                    throw new InvalidOperationException();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GrupaPracownikow gp1 = new GrupaPracownikow();

            Pracownik p1 = new Pracownik("Kowalski", "Programista");
            Pracownik p2 = new Pracownik("Paciaciak", "Księgowy");
            Pracownik p3 = new Pracownik("Nowak", "Sprzątaczka");

            gp1.DodajPracownika(p1);
            gp1.DodajPracownika(p2);
            gp1.DodajPracownika(p3);

            foreach (Pracownik p in gp1)
            {
                Console.WriteLine(p);
            }

        }
    }
}
