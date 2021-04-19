using System;
using System.Collections.Generic;
using System.Text;

namespace PD06._03
{
    public class Ticket : Item
    {
        public string Band;
        public string ConcertName;

        public Ticket(string band, string concertName, double price) : base(price, concertName)
        {
            Band = band;
            ConcertName = concertName;
            Price = price;
        }

        public string ConcertInfo()
        {
            return string.Format("{0} {1} {2}", Band, ConcertName, Price);
        }
    }
}
