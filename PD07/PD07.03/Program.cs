using System;
using System.IO;

namespace PD07._03
{
    class FileDoesntExistException : ApplicationException
    {
        public FileDoesntExistException(string message) : base(message) { }
    }

    static class Rewrite
    {
        public static void RewriteInUppercase()
        {
            Console.WriteLine("Enter file path");
            string path1 = Console.ReadLine();

            if (File.Exists(path1) == true)
            {
                Console.WriteLine("Enter new file path");
                string path2 = Console.ReadLine();
                StreamReader sr = new StreamReader(path1);
                StreamWriter sw = new StreamWriter(path2);

                while (!sr.EndOfStream)
                {
                    sw.WriteLine((sr.ReadLine()).ToUpper());
                }
                sr.Close();
                sw.Close();
            }   
            else
            {
                throw new FileDoesntExistException("This file doesn't exist!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rewrite.RewriteInUppercase();
        }
    }
}
