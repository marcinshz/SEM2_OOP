using System;
using System.IO;

namespace PD07._04
{
    class Employee
    {
        private string surname;
        private double salary;
        private double bonuspercent;

        public Employee(string surname, double salary, double bonuspercent)
        {
            this.surname = surname;
            this.salary = salary;
            this.bonuspercent = bonuspercent;
        }
        
        public string Surname { get { return surname; } }

        public double Salary 
        { 
            get { return salary; }
            set { salary = value; }
        }

        public double Bonus
        {
            get { return bonuspercent; }
            set { bonuspercent = value; }
        }

        public double Payment()
        {
            return (salary + (salary * bonuspercent));
        }
    }
    class Employees
    {
        Employee[] employees;

        public Employees()
        {
            this.employees = new Employee[20];
        }

        public void Program()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("N - Add new employee");
            Console.WriteLine("P - Change employee's salary");
            Console.WriteLine("R - Change employee's bonus");
            Console.WriteLine("W - Sum all salaries");
            Console.WriteLine("Z - Save employees list to file");
            Console.WriteLine("O - Read employees list from file");
            Console.WriteLine("K - Quit");

            string selectedOption = Console.ReadLine();

            switch(selectedOption)
            {
                case "N":
                    N();
                    break;
                case "P":
                    P();
                    break;
                case "R":
                    R();
                    break;
                case "W":
                    W();
                    break;
                case "Z":
                    Z();
                    break;
                case "O":
                    O();
                    break;
                case "K":
                    K();
                    break;
                default:
                    Console.WriteLine("Wrong letter");
                    Program();
                    break;
            }
        }

        private void K()
        {
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        private Employee ReadEmployee(string line)
        {
            string tmp = null;

            string[] employeeInfo = new string[3];

            for (int i = 0; i < employeeInfo.Length; i++)
            {
                for (int j = 0; j < line.Length; j++)
                {
                    bool condition = (line[j] != '|');

                    if (condition == true)
                    {
                        tmp += line[j];
                    }
                    else if (condition == false && tmp != null)
                    {
                        employeeInfo[i] = tmp;
                        tmp = null;
                        i++;
                    }
                }
            }
            string surname = employeeInfo[0];
            double salary = Double.Parse(employeeInfo[1]);
            double bonuspercent = Double.Parse(employeeInfo[2]);
            Employee e = new Employee(surname, salary, bonuspercent);
            return e;
        }
        private void O()
        {
            Console.WriteLine("Enter file path");
            string path = Console.ReadLine();
            StreamReader sr = new StreamReader(path);

            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                AddEmployee(ReadEmployee(line));
            }
            sr.Close();

            Console.WriteLine();
            Console.WriteLine("File read");
            Console.WriteLine();
            Program();
        }

        private void Z()
        {
            Console.WriteLine();
            Console.WriteLine("Enter saving path");
            string path = Console.ReadLine();
            StreamWriter sr = new StreamWriter(path);

            int i = 0;
            while(employees[i] != null)
            {
                string surname = employees[i].Surname;
                double salary = employees[i].Salary;
                double bonuspercent = employees[i].Bonus;
                sr.WriteLine($"|{surname}|{salary}|{bonuspercent}|");
                i++;
            }
            sr.Close();
            Console.WriteLine();
            Console.WriteLine("Saved to file");
            Console.WriteLine();
            Program();
        }

        private void W()
        {
            double sum = 0;
            int i = 0;
            while (employees[i] != null)
            {
                sum += employees[i].Payment();
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine();
            Program();
        }

        private void R()
        {
            Console.WriteLine();
            Console.WriteLine("What the employee's surname is?");
            string surname = Console.ReadLine();
            int i = Find(surname);

            if (i == -1)
            {
                Console.WriteLine("Wrong surname!");
            }
            else
            {
                Console.WriteLine("Enter new bonus:");
                employees[i].Bonus = Double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Bonus changed");
            }
            Console.WriteLine();
            Program();
        }
        private int Find(string surname)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Surname == surname)
                {
                    return i;
                }
            }
            return -1;
        }
        private void P()
        {
            Console.WriteLine();
            Console.WriteLine("What the employee's surname is?");
            string surname = Console.ReadLine();
            int i = Find(surname);

            if (i == -1)
            {
                Console.WriteLine("Wrong surname!");
            }
            else
            {
                Console.WriteLine("Enter new salary:");
                employees[i].Salary = Double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Salary changed");
            }
            Console.WriteLine();
            Program();
        }
        private void AddEmployee(Employee e)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = e;
                    return;
                }
            }
            Console.WriteLine("No space!");
        }
        private void N()
        {
            Console.WriteLine();
            Console.WriteLine("Employee's surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Employee's salary:");
            double salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Employee's bonus:");
            double bonuspercent = Double.Parse(Console.ReadLine());
            Employee e = new Employee(surname, salary, bonuspercent);
            AddEmployee(e);
            Console.WriteLine();
            Console.WriteLine("Employee Added");
            Console.WriteLine();
            Program();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employees es = new Employees();
            es.Program();

            Console.WriteLine();
        }
    }
}
