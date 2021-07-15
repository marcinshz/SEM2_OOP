using System;

namespace LAB12._02
{
    public delegate void Funkcja(string s);
    class Operacje
    {
        public static void naDuze(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        public static void naMale(string s)
        {
            Console.WriteLine(s.ToLower());
        }
        public static void Odwroc(string s)
        {
            string tmp = "";
            for (int i = s.Length-1; i > -1; i--)
            {
                tmp += s[i];
            }
            Console.WriteLine(tmp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funkcja f1 = Operacje.naDuze;
            f1 += Operacje.naMale;
            f1 += Operacje.Odwroc;

            f1("JiMmy");
        }
    }
}
