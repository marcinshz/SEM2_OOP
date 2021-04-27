using System;

namespace PD07._05
{
    class DivideByZeroException : ApplicationException
    {
        public DivideByZeroException(string message) : base(message)
        {}
    }
    struct Complex
    {
        //a - real part
        //b - imaginary part
        public double a;
        public double b;
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Divide(double x)
        {
            if (x!=0)
            {
                double c = a / x;
                double d = b / x;
                a = c;
                b = d;
            }
            else
            {
                throw new DivideByZeroException("Don't divide by zero!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(4, 6);
            c.Divide(2);
            Console.WriteLine(c.a);
            Console.WriteLine(c.b);

            c.Divide(0);
        }
    }
}
