using System;

namespace LAB07._03
{
    class MyException : ApplicationException
    {
        public MyException(string message):base(message)
        {
        }
    }
    class Program
    {
        public static double Divide(double a,double b)
        {
            if (b!=0)
            {
                return a / b;
            }
            else
            {
                throw new MyException("Do not divide by 0");
            }
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            try
            {
                int c = b / a;
                Console.WriteLine(c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("End");
            }
        }
    }
}
