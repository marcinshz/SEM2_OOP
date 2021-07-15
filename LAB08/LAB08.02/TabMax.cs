using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB08._03.TabMax
{
    class TabMax
    {
        int rozmiar;
        uint[] tab;
        int max;

        public TabMax(int rozmiar)
        {
            this.rozmiar = rozmiar;
            this.tab = new uint[rozmiar];
            this.max = tab.Length - 1;
        }

        public uint this[int i]
        {
            get
            {
                if (i > max || i < 0)
                {
                    throw new WrongIndexException($"Zły indeks! Maksymalny to {max}");
                }
                return tab[i];
            }
            set
            {
                if (i > max || i < 0)
                {
                    throw new WrongIndexException($"Zły indeks! Maksymalny to {max}");
                }
                tab[i] = value;
            }
        }

    }
}
