using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB08._04.Firma
{
    class Pracownik
    {
        internal string nazwisko;
        internal double pensja;
        internal double procentPremii;

        public Pracownik(string nazwisko, double pensja, double procentPremii)
        {
            this.nazwisko = nazwisko;
            this.pensja = pensja;
            this.procentPremii = procentPremii;
        }

        public double Wyplata()
        {
            return pensja + procentPremii * pensja;
        }
    }
}
