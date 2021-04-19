using System;
using System.Collections.Generic;
using System.Text;

namespace PD06._03
{
    public class Coffee : Item
    {
        public string Name;
        public string Producer;
        public double PriceNet;

        public Coffee(string Name, string Producer, double PriceNet) : base(PriceNet, Name)
        {
            this.Name = Name;
            this.Producer = Producer;
            this.PriceNet = PriceNet;
        }

        public string GetInfo()
        {
            return string.Format("{0} {1} {2}", Name, Producer, PriceNet);
        }

    }
}
