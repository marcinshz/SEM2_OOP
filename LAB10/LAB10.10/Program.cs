using System;
using System.IO;

namespace LAB10._10
{
    public class WriteToFile : IDisposable
    {
        StreamWriter file;
        string text;
        public WriteToFile(string _file, string _text)
        {
            file = new StreamWriter(_file, true);
            text = _text;
        }

        public void WriteText()
        {
            file.WriteLine(text);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
