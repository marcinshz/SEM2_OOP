using System;

namespace PD09._01
{
    class KlasaOgolna<T>
    {
        T value;
        string description;

        public KlasaOgolna(string description, T value)
        {
            this.description = description;
            this.value = value;
        }

        public void Display()
        {
            Console.WriteLine(value.ToString());
            Console.WriteLine();
            Console.WriteLine(description);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            KlasaOgolna<int> ko = new KlasaOgolna<int>("Liczba całkowita dodatnia", 5);
            ko.Display();
        }
    }
}
