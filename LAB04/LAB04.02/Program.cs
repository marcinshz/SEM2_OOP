using System;

namespace LAB04._02
{
    abstract class Figura
    {
        private string kolor;
        public Figura(string kolor)
        {
            this.kolor = kolor;
        }

        public abstract double Pole();
        public abstract double Obwod();
        public abstract void Wyswietl();
        public string Kolor 
        { get { return kolor; } }
    }

    class Prostokat : Figura
    {
        double a;
        double b;

        public Prostokat(double a, double b, string kolor) : base(kolor)
        {
            this.a = a;
            this.b = b;
        }

        public override double Pole()
        {
            return a * b;
        }
        public override double Obwod()
        {
            return 2 * a + 2 * b;
        }
        public override void Wyswietl()
        {
            Console.WriteLine($"Bok a: {a}, Bok b: {b}, Pole: {Pole()}, Obwód: {Obwod()}, Kolor: {Kolor}");
        }
    }
    class Kwadrat : Figura
    {
        double a;
        public Kwadrat(double a, string kolor) : base(kolor)
        {
            this.a = a;
        }
        public override double Pole()
        {
            return a * a;
        }
        public override double Obwod()
        {
            return 4 * a;
        }
        public override void Wyswietl()
        {
            Console.WriteLine($"Bok a: {a}, Pole: {Pole()}, Obwód: {Obwod()}, Kolor: {Kolor}");
        }
    }
    class Kolo : Figura
    {
        double r;
        public Kolo(double r, string kolor) : base(kolor)
        {
            this.r = r;
        }
        public override double Pole()
        {
            return Math.PI * Math.Pow(r,2);
        }
        public override double Obwod()
        {
            return 2 * Math.PI * r;
        }
        public override void Wyswietl()
        {
            Console.WriteLine($"Promień: {r}, Pole: {Pole()}, Obwód: {Obwod()}, Kolor: {Kolor}");
        }
    }
    class Program
    {
        static void Wypisania(Figura f)
        {
            f.Wyswietl();
        }
        static void Main(string[] args)
        {
            Prostokat p1 = new Prostokat(5, 6, "biały");
            Kwadrat k1 = new Kwadrat(4, "żółty");
            Kolo o1 = new Kolo(7, "Czerwony");
            Figura[] figury = { p1, k1, o1 };
            for (int i = 0; i < figury.Length; i++)
            {
                Wypisania(figury[i]);
            }
        }
    }
}
