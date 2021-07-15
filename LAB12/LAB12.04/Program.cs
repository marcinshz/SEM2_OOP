using System;

namespace LAB12._04
{
    public delegate int[] PrzekazMetode(Metoda m, int[] tab);
    public delegate int[] Metoda(int[] tab);
    class Tab 
    {
        public static int[] Sortuj(Metoda m, int[] tab)
        {
            return m(tab);
        }
        public static int[] SortujRosnaco(int[] tab)
        {
            Array.Sort(tab);
            return tab;
        }
        public static int[] SortujMalejaco(int[] tab)
        {
            //2 4 9 7 8
            Array.Sort(tab);
            int[] tmp = new int[tab.Length];
            for (int j = 0; j < tab.Length; j++)
            {
                for (int i = tab.Length - 1; i > -1; i--)
                {
                    tmp[j] = tab[i];
                    j++;
                }
            }
            return tmp;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] t1 = { 1, 3, 2, 0, 8 };


            int[] wynik1 = Tab.Sortuj(Tab.SortujMalejaco, t1);
            int[] wynik2= Tab.Sortuj(Tab.SortujRosnaco, t1);

            Console.WriteLine("Sortowanie malejąco:");
            for (int i = 0; i < wynik1.Length; i++)
            {
                Console.WriteLine(wynik1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Sortowanie rosnąco:");
            for (int i = 0; i < wynik2.Length; i++)
            {
                Console.WriteLine(wynik2[i]);
            }
        }
    }
}
