using System;

namespace LAB12._06
{
    public delegate Vector Funkcja(int x);
    public class Vector
    {
        double[] v;

        public Vector(int n)
        {
            this.v = new double[n];
        }
        public double this[int i]
        {
            get { return v[i]; }
            set { v[i] = value; }
        }
        public static Vector Oblicz(Funkcja f, int x)
        {
            return f(x);
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
