using System;

namespace LAB04._01
{
    abstract class Szyfr
    {
        protected int klucz;
        public Szyfr(int klucz)
        {
            this.klucz = klucz;
        }

        public abstract string Zaszyfruj(string o);
        public abstract string Odszyfruj(string o);
    }

    class SzyfrCezara : Szyfr
    {
        public SzyfrCezara(int klucz) : base(klucz)
        {
        }

        public override string Zaszyfruj(string o)
        {
            char[] tab = new char[o.Length];
            for(int i = 0; i < o.Length; i++)
            {
                tab[i] = (char)(o[i] + klucz);
            }
            return new string(tab);
        }
        public override string Odszyfruj(string o)
        {
            char[] tab = new char[o.Length];
            for (int i = 0; i < o.Length; i++)
            {
                tab[i] = (char)(o[i] - klucz);
            }
            return new string(tab);
        }
    }
    class SzyfrXor : Szyfr
    {
        public SzyfrXor(int klucz) : base(klucz)
        {

        }
        public override string Zaszyfruj(string o)
        {
            char[] tab = new char[o.Length];
            for (int i = 0; i < o.Length; i++)
            {
                tab[i] = (char)(o[i] ^ klucz);
            }
            return new string(tab);
        }
        public override string Odszyfruj(string o)
        {
            char[] tab = new char[o.Length];
            for (int i = 0; i < o.Length; i++)
            {
                tab[i] = (char)(o[i] ^ klucz);
            }
            return new string(tab);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SzyfrXor szyfr = new SzyfrXor(4);
            string napis = "tekst";
            string zaszyfrowany = szyfr.Zaszyfruj(napis);
            Console.WriteLine(zaszyfrowany);
            string odszyfrowany = szyfr.Odszyfruj(zaszyfrowany);
            Console.WriteLine(odszyfrowany);
        }
    }
}
