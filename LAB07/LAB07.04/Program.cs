using System;
using System.IO;

namespace LAB07._04
{
    class Computer
    {
        public string name;
        public string manufacturer;
        public int ram;
        public double diskcapacity;
        public double price;

        public Computer(string name, string manufacturer, int ram, double diskcapacity, double price)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.ram = ram;
            this.diskcapacity = diskcapacity;
            this.price = price;
        }
    }
    class Base
    {
        Computer[] computerBase;

        public Base()
        {
            this.computerBase = new Computer[20];
        }

        public void Program()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();

            Console.WriteLine("C - Copy base from file");
            Console.WriteLine("N - Add computer to the base");
            Console.WriteLine("W - Display whole base");
            Console.WriteLine("Z - Save base to file");
            Console.WriteLine("Q - Quit");

            string answer = Console.ReadLine();

            switch(answer)
            {
                case "C":
                    C();
                    break;
                case "N":
                    N();
                    break;
                case "W":
                    W();
                    break;
                case "Z":
                    Z();
                    break;
                case "Q":
                    Q();
                    break;
                default:
                    Console.WriteLine("Wrong letter");
                    Program();
                    break;
            }
            
        }
        //Making computer object from info string
        //line template:
        //|name|manufacturer|ram|diskcapacity|price|
        public Computer makeObject(string line)
        {
            string[] info = new string[5];
            string tmp = null;
            for (int j = 0; j < info.Length; j++)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    bool condition = (line[i] != '|');

                    if (condition == true)
                    {
                        tmp += line[i];
                    }
                    else if (condition == false && tmp != null)
                    {
                        info[j] = tmp;
                        tmp = null;
                        j++;
                    }
                }
            }

            Computer c = new Computer(info[0], info[1], Int32.Parse(info[2]), Double.Parse(info[3]), Double.Parse(info[4]));

            return c;
        }
        public void AddToBase(Computer c)
        {
            for (int i = 0; i < computerBase.Length; i++)
            {
                if (computerBase[i] == null)
                {
                    computerBase[i] = c;
                    return;
                }
            }

            Console.WriteLine("No space!");
        }
        //Copying base from file,
        public void C()
        {
            string line = "";
            int counter = 0;
            Computer tmp = null;
            Console.WriteLine("Please write name of the file");
            string path = Console.ReadLine();
            StreamReader sr = new StreamReader(path);

            while(!sr.EndOfStream)
            { 
                line = sr.ReadLine();
                counter++;
                tmp = makeObject(line);
                AddToBase(tmp);
            }
            sr.Close();
            Console.WriteLine("Base copied");
            Console.WriteLine($"Number of computers: {counter}");

            Console.WriteLine();
            Console.WriteLine("Anything else?");
            Program();
        }
        //Adding computer
        public void N()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the manufacturer");
            string manufacturer = Console.ReadLine();

            Console.WriteLine("Enter ram capacity");
            int ram = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter hard drive capacity");
            double diskcapacity = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price");
            double price = Double.Parse(Console.ReadLine());

            Computer c = new Computer(name, manufacturer, ram, diskcapacity, price);

            AddToBase(c);

            Console.WriteLine("Computer added to the base");

            Console.WriteLine();
            Console.WriteLine("Anything else?");
            Program();
        }

        //Displaying whole base
        //|name|manufacturer|ram|diskcapacity|price|
        public void W()
        {
            int i = 0;
            Console.WriteLine("Base:");
            while(computerBase[i] != null)
            {
                string name = computerBase[i].name;
                string manufacturer = computerBase[i].manufacturer;
                int ram = computerBase[i].ram;
                double diskcapacity = computerBase[i].diskcapacity;
                double price = computerBase[i].price;
                Console.WriteLine($"Name: {name}, Manufacturer: {manufacturer}, RAM: {ram}, Hard drive capacity: {diskcapacity}, Price: {price}");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Anything else?");
            Program();
        }

        //Saving base to file
        public void Z()
        {
            Console.WriteLine("Please write name of the file");
            string path = Console.ReadLine();
            StreamWriter sw = new StreamWriter(path);
            int i = 0;
            while(computerBase[i] != null)
            {
                string name = computerBase[i].name;
                string manufacturer = computerBase[i].manufacturer;
                int ram = computerBase[i].ram;
                double diskcapacity = computerBase[i].diskcapacity;
                double price = computerBase[i].price;
                sw.WriteLine($"|{name}|{manufacturer}|{ram}|{diskcapacity}|{price}|");
                i++;
            }
            sw.Close();

            Console.WriteLine();
            Console.WriteLine("Anything else?");
            Program();
        }

        public void Q()
        {
            Console.WriteLine("Click any button to exit");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Program();

        }
    }
}
