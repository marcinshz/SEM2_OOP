using System;

namespace LAB02._03
{
    static class Rozszerzenie
    {
        public static string PostacBinarna(this int n)
        {
            string binarnie = "";
            int m = n;
            while (m > 0)
            {
                if (m % 2 == 0)
                {
                    binarnie += "0";
                }
                else
                {
                    binarnie += "1";
                }
                m = m / 2;
            }
            return binarnie;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 7;
        }
    }
}
