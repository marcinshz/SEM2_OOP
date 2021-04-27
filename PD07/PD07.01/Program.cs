using System;
using System.IO;
namespace PD07._01
{
    class Program
    {
        public static int CountPositive(string path)
        {
            //Counts positive numbers in the file
            int counter = 0;
            StreamReader sr = new StreamReader(path);
            while(!sr.EndOfStream)
            {
                if (Int32.Parse(sr.ReadLine()) > 0)
                {
                    counter++;
                }
            }
            sr.Close();
            return counter;
        }
        public static int[] ReadPositive(string readpath)
        {
            //Reads positive numbers and saves them to an array
            StreamReader sr = new StreamReader(readpath);
            int[] positive = new int[CountPositive(readpath)];

            for (int i = 0; i < positive.Length; i++)
            {
                int number = Int32.Parse(sr.ReadLine());
                if (number > 0)
                {
                    positive[i] = number;
                }
                else
                {
                    i--;
                }
            }
            sr.Close();
            return positive;
        }

        //Saves array to the file
        public static void SavePositive(string savepath, string readpath)
        {
            StreamWriter sw = new StreamWriter(savepath);
            int[] tab = ReadPositive(readpath);

            for (int i = 0; i < tab.Length; i++)
            {
                sw.WriteLine(tab[i]);
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            SavePositive("test.txt", "Dane.txt");
        }
    }
}
