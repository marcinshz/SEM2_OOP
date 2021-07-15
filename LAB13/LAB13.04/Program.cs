using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB13._04
{
    [Serializable]
    class Komputer
    {
        [NonSerialized]
        private double cena;

        private string marka;

        public Komputer(string marka, double cena)
        {
            this.cena = cena;
            this.marka = marka;
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
            return marka + " " + cena;
        }
    }
    class DataSerializer
    {
        public void BinarySerializer(Object obj, string path)
        {
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path)) File.Delete(path);
            fs = File.Create(path);
            bf.Serialize(fs, obj);
            fs.Close();
        }

        public Object BinaryDeserializer(string path)
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
            Komputer k1 = new Komputer("Acer", 2000);
            Komputer k2 = new Komputer("Dell", 4000);
            Komputer k3 = new Komputer("Lenovo", 4020);

            List<Komputer> komputery1 = new List<Komputer>();
            komputery1.Add(k1);
            komputery1.Add(k2);
            komputery1.Add(k3);
            DataSerializer ds = new DataSerializer();
            ds.BinarySerializer(komputery1, "komputery1.dat");

            List<Komputer> komputery2 = (List<Komputer>)ds.BinaryDeserializer("komputery1.dat");
            Console.WriteLine();
            
        }
    }
}
