using System;
using System.Collections.Generic;

namespace PD09._02
{
    class MyComparer<T> : IComparer<T>
    {
        public int Compare(T? x, T? y)
        {
            if (x.GetHashCode() > y.GetHashCode())
            {
                return 1;
            }
            if (x.GetHashCode()<y.GetHashCode())
            {
                return -1;
            }
            return 0;
        }
    }
    class Program
    {
        static T ZnajdzMax1<T>(T[] tab) where T:IComparable<T>
        {
            T tmp = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].CompareTo(tmp) > 0)
                {
                    tmp = tab[i];
                }
            }
            return tmp;
        }
        static T ZnajdzMax2<T>(T[] tab)
        {
            MyComparer<T> mc = new MyComparer<T>();
            T tmp = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (mc.Compare(tab[i],tmp) > 0)
                {
                    tmp = tab[i];
                }
            }
            return tmp;
        }
        static void Main(string[] args)
        {
            int[] tab1 = { 23, 5, 18, 29, 31, 6, 91, 32, 101, 82 };
            Console.WriteLine(ZnajdzMax1<int>(tab1));
            Console.WriteLine(ZnajdzMax2<int>(tab1));
        }
    }
}
