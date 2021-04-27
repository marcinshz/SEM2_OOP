using System;
using System.IO;

namespace PD07._02
{
    static class SortAlphabetically
    {
        //Counts lines(words)
        public static int Count(string readpath)
        {
            StreamReader sr = new StreamReader(readpath);
            int counter = 0;
            while (!sr.EndOfStream)
            {
                if (sr.ReadLine() == null)
                {
                    return counter;
                }
                counter++;
            }
            sr.Close();
            return counter;
        }
        //Reads and saves strings to an array
        public static string[] Read(string readpath)
        {
            string[] s = new string[Count(readpath)];
            StreamReader sr = new StreamReader(readpath);

            int i = 0;
            while(!sr.EndOfStream)
            {
                s[i] = sr.ReadLine();
                i++;
            }
            sr.Close();
            //sorts an array alphabetically
            Array.Sort(s);
            return s;
        }
        //Saves sorted strings to file
        public static void SortAndSave(string readpath, string savepath)
        {
            StreamWriter sw = new StreamWriter(savepath);
            string[] s = Read(readpath);

            for (int i = 0; i < s.Length; i++)
            {
                sw.WriteLine(s[i]);
            }
            sw.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortAlphabetically.SortAndSave("input.txt", "output.txt");

            //Console.WriteLine(SortAlphabetically.Count("input.txt"));
        }
    }
}
