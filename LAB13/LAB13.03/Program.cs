using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB13._03
{
    [Serializable]
    public class Osoba
    {
        int pesel;
        string nazwisko;
        [NonSerialized]
        double dochod;

        public Osoba(string nazwisko,int pesel)
        {
            this.nazwisko = nazwisko;
            this.pesel = pesel;
        }

        public double Dochod
        {
            get { return dochod; }
            set { if (value >= 1) dochod = value; }
        }
        public override string ToString()
        {
            return $"PESEL: {pesel}, Nazwisko: {nazwisko}, Dochód: {dochod}";
        }
    }
    public class DataSerializer
    {
        public void BinarySerialize(object data, string path)
        {
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path)) File.Delete(path);

            fs = File.Create(path);
            bf.Serialize(fs, data);
            fs.Close();
        }
        public Object BinaryDeSerialize(string path)
        {
            Object obj = null;
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(path))
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
            //Serializacja i Deserializacja pojedynczej osoby
            Osoba o1 = new Osoba("Chodkowski", 01492810242);
            DataSerializer ds = new DataSerializer();
            ds.BinarySerialize(o1, "osoba1.dat");
            
            Osoba o2 = (Osoba)ds.BinaryDeSerialize("osoba1.dat");

            //Serializacja i Deserializacja listy osób
            Osoba o3 = new Osoba("Kowalski", 123);
            Osoba o4 = new Osoba("Nowak", 325);
            Osoba o5 = new Osoba("Małysz", 521);

            List<Osoba> l1 = new List<Osoba>();
            l1.Add(o3);
            l1.Add(o4);
            l1.Add(o5);

            ds.BinarySerialize(l1, "lista1.dat");

            List<Osoba> l2 = (List<Osoba>)ds.BinaryDeSerialize("lista1.dat");
        }
    }
}
