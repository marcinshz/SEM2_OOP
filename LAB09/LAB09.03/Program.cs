using System;
using System.Collections.Generic;

namespace LAB09._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> slownik = new Dictionary<int, int>();
            Console.WriteLine("Podaj kilka liczb, 0 konczy wprowadzanie");
            int wartosc = 0;
            while((wartosc=Convert.ToInt32(Console.ReadLine())) != 0)
            {
                if (!slownik.ContainsKey(wartosc))
                {
                    slownik.Add(wartosc, 1);
                }
                else
                {
                    slownik[wartosc]++;
                }
            }
            foreach(KeyValuePair<int,int> item in slownik)
            {
                Console.WriteLine("Wartosc {0} wystapila {1} razy", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
