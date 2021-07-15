using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB13._05
{
    [Serializable]
    public class Osoba
    {
        int pesel;
        string nazwisko;
        [NonSerialized]
        double dochod;

        public Osoba(string nazwisko, int pesel)
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
    [Serializable]
    public class Student : Osoba
    {
        string kierunek;
        int nrIndeksu;

        public Student(string nazwisko,int pesel,string kierunek,int nrIndeksu):base(nazwisko,pesel)
        {
            this.kierunek = kierunek;
            this.nrIndeksu = nrIndeksu;
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
            //Serializacja i deserializacja pojedynczego studenta
            Student s1 = new Student("Chodkowski", 123, "Informatyka", 321);
            DataSerializer ds = new DataSerializer();

            ds.BinarySerialize(s1, "s1.dat");

            Student s2 = (Student)ds.BinaryDeserialize("s1.dat");
            Console.WriteLine();

            //Serializacja i deserializacja listy osób, w której są studenci
            List<Osoba> osoby1 = new List<Osoba>();
            Osoba o1 = new Osoba("Nowak", 987);

            osoby1.Add(o1);
            osoby1.Add(s1);

            ds.BinarySerialize(osoby1, "osoby1.dat");
            List<Osoba> osoby2 = (List<Osoba>)ds.BinaryDeserialize("osoby1.dat");

            Console.WriteLine();
        }
    }
}
