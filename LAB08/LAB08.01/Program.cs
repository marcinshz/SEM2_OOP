using System;

namespace LAB08._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Figury.Czworokaty.Kwadrat k = new Figury.Czworokaty.Kwadrat(5);
            Console.WriteLine(k.Obwod());
            Console.WriteLine(k.Pole());

            Figury.Trojkaty.TrojkatRownoboczny t = new Figury.Trojkaty.TrojkatRownoboczny(3);
            Console.WriteLine(t.Obwod());
            Console.WriteLine(t.Pole());
        }
    }
}
