using System;
using System.Collections.Generic;
using System.Text;

namespace PD06._03
{
    class Book : Item
    {
        protected string author;
        protected string ISBN;
        protected uint pageNumber;
        protected string publisher;

        public double returnPriceBrutto
        {
            get { return price * 1.08; }
        }

        public Book(string title, string author, string ISBN, uint pageNumber, string publisher, double price) : base(price, title)
        {
            Price = price;
            Title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.pageNumber = pageNumber;
            this.publisher = publisher;

        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", Title, author, ISBN, pageNumber, Price);
        }
    }
}
