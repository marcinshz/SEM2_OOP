using System;
using System.IO;
/*
1 gr  - a
2 gr  - b
5 gr  - c
10 gr - d
20 gr - e
50 gr - f
1 zł  - A
2 zł  - B
5 zł  - C
*/
namespace LAB07._02
{
    class VendingMachine
    {
        public static double Count(string path)
        {
            double sum = 0;
            StreamReader sr = new StreamReader(path);
            string input = null;

            while ((input = sr.ReadLine()) != null)
            {
                switch(input)
                {
                    case "a":
                        sum += 0.01;
                        break;
                    case "b":
                        sum += 0.02;
                        break;
                    case "c":
                        sum += 0.05;
                        break;
                    case "d":
                        sum += 0.1;
                        break;
                    case "e":
                        sum += 0.2;
                        break;
                    case "f":
                        sum += 0.5;
                        break;
                    case "A":
                        sum += 1;
                        break;
                    case "B":
                        sum += 2;
                        break;
                    case "C":
                        sum += 5;
                        break;

                    default:
                        break;
                }
            }
            sr.Close();
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VendingMachine.Count("plik.txt"));
        }
    }
}
