using System;
using System.Collections.Generic;
using System.Text;

namespace PD06._03
{
    interface ItemComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            return x.Title.CompareTo(y);
        }
    }

    interface CDComparer : IComparer<CD>
    {
        public int Compare(CD x, CD y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

}
