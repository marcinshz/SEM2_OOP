using System;

namespace PD04._03
{
    class Element
    {
        Object x;
        private string opis;
        public Element(Object x, string opis)
        {
            this.x = x;
            this.opis = opis;
        }
        public Element(string opis)
        {
            this.opis = opis;
        }
        public string Opis
        {
            get {return opis;}
        }
    }
    class Zbior
    {
        Element[] zbior;
        public Zbior(Element[] zbior)
        {
            this.zbior = zbior;
        }
        public Zbior()
        {

        }
        public void DodajElement(Element dodawany)
        {
            if (zbior == null || zbior.Length == 0)
            {
                zbior = new Element[1];
                zbior[0] = dodawany;
            }
            else
            {
                for (int i = 0; i < zbior.Length; i++)
                {
                    if (zbior[i] == null)
                    {
                        zbior[i] = dodawany;
                    }
                    else if (i == zbior.Length-1 && zbior[i] != null)
                    {
                        Array.Resize(ref zbior, zbior.Length + 1);
                        zbior[i + 1] = dodawany;
                        break;
                    }
                }
            }
        }
        public Zbior SumaZbiorow(Zbior zb)
        {
            int tmp1 = zbior.Length;
            int tmp2 = 0;
            Array.Resize(ref zbior, zbior.Length + zb.zbior.Length);
            for (int i = tmp1; i < zbior.Length; i++)
            {
                if (zbior[i] == null)
                {
                    zbior[i] = zb.zbior[tmp2];
                    tmp2++;
                }
            }
            Zbior suma = new Zbior(zbior);
            return suma;
        }
        public bool CzyZawiera(Element e)
        {
            for (int i = 0; i < zbior.Length; i++)
            {
                if (e == zbior[i])
                {
                    return true;
                }
            }
            return false;
        }
        public int policzPowtorki(Zbior zb)
        {
            int licznik = 0;
            for (int i = 0; i < zb.zbior.Length; i++)
            {
                for (int j = 0; j < zbior.Length; j++)
                {
                    if (zb.zbior[i] == zbior[j])
                    {
                        licznik++;
                        i++;
                        j = 0;
                    }
                }
            }
            return licznik;
        }
        public Zbior CzescWspolna(Zbior zb)
        {
            Object[] czescWspolna = new object[policzPowtorki(zb)];
            for (int i = 0; i < zb.zbior.Length; i++)
            {
                for (int j = 0; j < zbior.Length; j++)
                {
                    if (zb.zbior[i] == zbior[j])
                    {
                        
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zbior zb1 = new Zbior();
            Element e1 = new Element("x");
            Element e2 = new Element("y");
            Element e3 = new Element("z");
            Element e4 = new Element("t");
            zb1.DodajElement(e1);
            zb1.DodajElement(e2);
            zb1.DodajElement(e3);
            zb1.DodajElement(e4);


            Zbior zb2 = new Zbior();
            Element e5 = new Element("a");
            Element e6 = new Element("b");
            Element e7 = new Element("c");
            zb2.DodajElement(e5);
            zb2.DodajElement(e6);
            zb2.DodajElement(e7);


            Zbior suma_zb1_zb2 = zb1.SumaZbiorow(zb2);

            Console.WriteLine();
        }
    }
}
