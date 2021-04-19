using System;

namespace PD06._03
{
    public abstract class Item : IComparable
    {
        public double price;
        string title;

        public Item(double price, string title)
        {
            this.price = price;
            this.title = title;
        }

        public int CompareTo(object obj)
        {
            Item i2 = (Item)obj;
            if (price > i2.price)
            {
                return 1;
            }
            if (price == i2.price)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public double Price { get; set; }
        public string Title { get; set; }
        public double BruttoPrice { get; }

        public double VAT
        {
            get { return BruttoPrice - Price; }
        }
    }
}
