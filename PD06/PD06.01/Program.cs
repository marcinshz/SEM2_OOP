using System;
using System.Collections;
using System.Collections.Generic;
namespace PD06._01
{
    class String
    {
        char[] tekst;
        public String(string s)
        {
            this.tekst = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                tekst[i] = s[i];
            }
        }

        public class ByLength : IComparer
        {
            public int Compare(object x, object y)
            {
                if (((string)x).Length > ((string)y).Length)
                {
                    return 1;
                }
                else if (((string)x).Length == ((string)y).Length)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
