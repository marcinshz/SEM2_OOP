using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB13._07
{
    [Serializable]
    public class Osoba : ISerializable
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //Szyfrowanie peselu, klucz to 53
            info.AddValue("pesel", pesel<<53, typeof(int));
            info.AddValue("nazwisko", nazwisko);
        }
        public Osoba(SerializationInfo info, StreamingContext context)
        {
            pesel = (int)info.GetValue("pesel",typeof(int)) >>53;
            nazwisko = (string)info.GetString("nazwisko");
        }
        public override string ToString()
        {
            return $"PESEL: {pesel}, Nazwisko: {nazwisko}, Dochód: {dochod}";
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
            Osoba o1 = new Osoba("Chodkowski", 123);
            
            DataSerializer ds = new DataSerializer();
            ds.BinarySerialize(o1, "o1.dat");
            
            Osoba o2 = (Osoba)ds.BinaryDeserialize("o1.dat");
            Console.WriteLine();
           
        }
    }
}
