using System;

namespace PD05._04
{
    class Tekst
    {
        char[] napis;
        public Tekst(string tekst)
        {
            Array.Resize(ref napis, tekst.Length);
            for (int i = 0; i < napis.Length; i++)
            {
                napis[i] = tekst[i];
            }
        }

        public string ZamienNaString()
        {
            string tmp="";
            for (int i = 0; i < napis.Length; i++)
            {
                tmp += napis[i];
            }
            return tmp;
        }

        public int Dlugosc()
        {
            return napis.Length;
        }

        public void Odwroc()
        {
            Array.Reverse(napis);
        }

        public int IleRazyWystepuje(char c)
        {
            int licznik = 0;
            for (int i = 0; i < napis.Length; i++)
            {
                if(napis[i] == c)
                {
                    licznik++;
                }
            }
            return licznik;
        }
        public string UsunZnak(char c)
        {
            int x = IleRazyWystepuje(c);
            for (int j = 0; j < napis.Length; j++)
            {
                if (napis[j] == c)
                {
                    for (int i = j; i < napis.Length-1; i++)
                    {
                        napis[i] = napis[i + 1];
                    }
                }
            }
            Array.Resize(ref napis, napis.Length - x);
            return ZamienNaString();
        }
        public void Dodaj(string s)
        {
            int tmp = napis.Length;
            Array.Resize(ref napis, napis.Length + s.Length);
            for (int i = tmp; i < napis.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    napis[i] = s[j];
                    i++;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
