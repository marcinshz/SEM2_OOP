using System;

namespace PD07._08
{
    class WrongLim : ApplicationException
    {
        public WrongLim(string message) : base(message)
        { }
    }
    class WrongInd : ApplicationException
    {
        public WrongInd(string message):base(message)
        { }
    }
    class TabLim
    {
        int size;
        double[] tab;
        double max;
        double min;

        public TabLim(double max)
        {
            this.tab = new double[0];
            this.max = max;
            this.min = 0;
        }

        public void Add(double x)
        {
            if (tab.Length + 1 <= max)
            {
                Array.Resize(ref tab, tab.Length + 1);
                tab[tab.Length - 1] = x;
                return;
            }
            throw new WrongLim("Tab is full!");
        }

        public double this[int i]
        {
            get
            {
                if (i < 0 || i > max-1)
                {
                    throw new WrongInd("Wrong index");
                }
                return tab[i];
            }
            set
            {
                if (i < 0 || i > max - 1)
                {
                    throw new WrongInd("Wrong index");
                }
                tab[i] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TabLim tl = new TabLim(10);
            tl.Add(5);
            tl.Add(10);
            Console.WriteLine();
            tl[1] = 20;
            Console.WriteLine();
        }
    }
}
