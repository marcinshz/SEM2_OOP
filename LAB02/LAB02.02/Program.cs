using System;

namespace LAB02._02
{
    struct Punkt
    {
        double x, y;
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
    }

    struct Prostokat
    {
        Punkt p1, p2;

        public Prostokat(double x1, double y1, double x2, double y2)
        {
            p1 = new Punkt(Math.Min(x1, x2), Math.Min(y1, y2));
            p2 = new Punkt(Math.Max(x1, x2), Math.Max(y1, y2));
        }

        public Punkt P1
        {
            get { return p1; }
        }
        public Punkt P2
        {
            get { return p2; }
        }
        public double bokA
        {
            get { return p2.X - p1.X; }
        }
        public double bokB
        {
            get { return p2.Y - p1.Y; }
        }
        public double Pole()
        {
            return bokB * bokA;
        }
        public double Obwod()
        {
            return ((2 * bokB) + (2 * bokA));
        }
        public static Prostokat ProstokatWProstokacie(Prostokat r1, Prostokat r2)
        {
            double x1 = Math.Min(r1.P1.X, r2.P1.X);
            double y1 = Math.Min(r1.P1.Y, r2.P1.Y);

            double x2 = Math.Max(r1.P2.X, r2.P2.X);
            double y2 = Math.Max(r1.P2.Y, r2.P2.Y);

            return new Prostokat(x1, y1, x2, y2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Prostokat p = new Prostokat(1, 2, 2, 4);
            Console.WriteLine("prostokąt [{0};{1}] [{2};{3}]", p.P1.X, p.P1.Y, p.P2.X, p.P2.Y);
            Console.WriteLine(p.bokA);
            Console.WriteLine(p.bokB);
        }
    }
}
