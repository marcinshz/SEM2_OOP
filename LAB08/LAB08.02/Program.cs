using System;

namespace LAB08._03
{ 
    class Program
    {
        static void Main(string[] args)
        {
            TabMax.TabMax tm = new TabMax.TabMax(10);
            tm[2] = 3;
            Console.WriteLine(tm[2]);
        }
    }
}
