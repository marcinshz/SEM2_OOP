using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB07._01
{
    class CodingStream : FileStream
    {
        private int key;
        public CodingStream(int key, string path,FileMode mode, FileAccess acces) : base(path,mode,acces)
        {
            this.key = key;
        }
        public override void Write(byte[] array, int offset, int count)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)(array[i] ^ key);
            }

            base.Write(array, offset, count);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)(array[i] ^ key);
            }
        }

        public override int Read(byte[] array, int offset, int count)
        {
            int w = base.Read(array, offset, count);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)(array[i] ^ key);
            }
            return w;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CodingStream sk = new CodingStream(1111, "plik.bin", FileMode.OpenOrCreate, FileAccess.Write);
            char[] c = "sekret".ToArray();
            byte[] t = new byte[c.Length * sizeof(char)/sizeof(byte)];
            /*for (int i = 0, j = 0; i < c.Length; i++)
            {
                byte[] tmp = BitConverter.GetBytes(c[i]);
                for (int k = 0; k < sizeof(char) / sizeof(byte); k++)
                {
                    t[j++] = tmp[k];
                }
            }
            sk.Write(t, 0, t.Length);*/
            sk.Close();
            sk = new CodingStream(1111, "plik.bin", FileMode.Open, FileAccess.Read);
            int length = (int)sk.Length;
            t = new byte[length];
            char[] read = new char[length * sizeof(byte) / sizeof(char)];
            sk.Read(t, 0, length);
            sk.Close();
            for (int i = 0, j = 0; i < length; i += sizeof(char) / sizeof(byte))
            {
                read[j++] = BitConverter.ToChar(t, i);
            }
            Console.WriteLine(read);
        }
    }
}
