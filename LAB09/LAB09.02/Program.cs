using System;

namespace LAB09._02
{
    struct Para : IComparable<Para>
    {
        int a, b;
        public Para(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return string.Format("[{0}-{1}]", a, b);
        }
        public int CompareTo(Para other)
        {
            if (a != other.a)
            {
                return a.CompareTo(a);
            }
            else
            {
                return 0;
            }
        }
    }
    class Test<T> where T:struct, IComparable<T>
    {
        int rozmiar;
        T wartosc;
        T[] wsk;
        public Test(int roz)
        {
            if (roz <= 0) roz = 1;
            wsk = new T[roz];
            rozmiar = roz;
            for (int i = 0; i < roz; i++) wsk[i] = default(T);
            wartosc = default(T);
        }
        public int Rozmiar() { return rozmiar; }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > rozmiar - 1)
                {
                    throw (new Exception());
                }
                return wsk[index];
            }
            set
            {
                if (index < 0 || index > rozmiar - 1)
                {
                    throw (new Exception());
                }
                wsk[index] = value;
            }
        }

        public T GetWartosc() { return wartosc; }
        public void SetWartosc(T war) { wartosc = war; }
        public int Oblicz() // ile elementów mniejszych od wartości
        {
            int licz = 0;
            for (int i = 0; i < rozmiar; i++)
                if (wsk[i].CompareTo(wartosc)<=0) licz++;
            return licz;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test<double> t = new Test<double>(10);
            t.SetWartosc(7);
            t[0] = 1.1;
            t[1] = 9.9;
            Console.WriteLine(t.Oblicz());

            Test<int> ti = new Test<int>(5);
            ti[0] = 9;
            ti[1] = 12;
            ti[4] = 6;
            ti.SetWartosc(5);
            Console.WriteLine(ti.Oblicz());

            //Test<string> ts = new Test<string>(3);
            //ts[0] = "Ala";
            //ts[1] = "Ola";
            //ts[2] = "Jan";
            //ts.SetWartosc("Ivan");
            //Console.WriteLine(ts.Oblicz());

            Test<Para> tp = new Test<Para>(5);
            tp[0] = new Para(1, 2);
            tp[2] = new Para(2, 1);
            tp[4] = new Para(1, 0);
            tp.SetWartosc(new Para(1, 1));
            Console.WriteLine(tp.Oblicz());
        }
    }
}
