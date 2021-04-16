using System;
using System.Text;
using System.Diagnostics;

namespace LAB05._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;
            Stopwatch sw = new Stopwatch();

            string s = "Ala ma kota";
            string z = s;
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                z += s;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Reset();

            StringBuilder sb = new StringBuilder("Ala ma kota", 1100000);
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                sb.Append("Ala ma kota");
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Reset();
        }
    }
}
