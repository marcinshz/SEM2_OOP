using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB13._06
{
    [Serializable]
    class Producent
    {
        string nazwa;
        string kraj;
        int kod;

        public Producent(string n, string c, int k)
        {
            nazwa = n;
            kraj = c;
            kod = k;
        }

        public override string ToString()
        {
            return String.Format("'{0}  {1} kod {2}'", nazwa, kraj, kod);
        }
    }
    [Serializable]
    class Komputer
    {
        [NonSerialized]
        private double cena;

        private string marka;
        Producent producent;

        public Komputer(string marka, double cena, Producent producent)
        {
            this.cena = cena;
            this.marka = marka;
            this.producent = producent;
        }

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public string Marka
        {
            get { return marka; }
        }

        public override string ToString()
        {
            return marka + " " + cena + " " + producent;
        }
    }
    [Serializable]
    class Laptop : Komputer
    {
        string opis;
        int waga;

        public Laptop(string marka, double cena, Producent producent, string opis, int waga)
            : base(marka, cena, producent)
        {
            this.opis = opis;
            this.waga = waga;
        }

        public override string ToString()
        {
            return base.ToString() + "\ntyp laptop " + opis + " " + waga;
        }

    }
    class DataSerializer
    {
        public void BinarySerialize(Object obj, string path)
        {
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(path)) File.Delete(path);
            fs = File.Create(path);
            bf.Serialize(fs, obj);
            fs.Close();
        }

        public Object BinaryDeserialize(string path)
        {
            Object obj = null;
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();

            if(File.Exists(path))
            {
                fs = File.OpenRead(path);
                obj = bf.Deserialize(fs);
                fs.Close();
            }
            return obj;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Producent Acer = new Producent("Acer", "Jamajka", 1234);
            Producent Dell = new Producent("Dell", "Polska", 4321);
            Komputer k1 = new Komputer("Acer", 2000, Acer);
            Laptop p1 = new Laptop("Dell", 2500, Dell, "Super laptop", 1200);

            List<Komputer> komputery = new List<Komputer>();
            komputery.Add(k1);
            komputery.Add(p1);

            DataSerializer ds = new DataSerializer();

            ds.BinarySerialize(komputery,"komputery.dat");

            List<Komputer> komputery1 = (List<Komputer>)ds.BinaryDeserialize("komputery.dat");
            Console.WriteLine();

        }
    }
}
