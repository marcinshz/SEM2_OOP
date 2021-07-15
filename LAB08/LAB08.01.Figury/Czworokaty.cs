using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB08._01.Figury.Czworokaty
{
    public class Prostokat : Figura
    {
        public double a;
        public double b;

        public Prostokat(double bok1, double bok2)
        {
            this.a = bok1;
            this.b = bok2;
        }

        public override double Obwod()
        {
            return 2 * a + 2 * b;
        }

        public override double Pole()
        {
            return a * b;
        }
    }

    public class Kwadrat : Figura
    {
        public double a;

        public Kwadrat(double bok1)
        {
            this.a = bok1;
        }

        public override double Obwod()
        {
            return 4 * a;
        }

        public override double Pole()
        {
            return a * a;
        }
    }
}
