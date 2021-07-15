using System;

namespace LAB13._01
{
    //[AttributeUsage(AttributeTargets.Class,Inherited = true)]
    [Student("Marcin","Chodkowski","SGGW")]
    class Student : Attribute
    {
        public string imie;
        public string nazwisko;
        public string nazwaUczelni;

        public Student(string imie, string nazwisko, string nazwaUczelni)
        {
            this.imie = imie;
            this.nazwaUczelni = nazwaUczelni;
            this.nazwisko = nazwisko;
        }

        public Student() { }

        
    }

    [Student("Kamil","Nowak","PW")]
    class StudentZaoczny : Student
    {
        public StudentZaoczny(string imie, string nazwisko, string nazwaUczelni) : base(imie, nazwisko, nazwaUczelni) { }
        public StudentZaoczny():base() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Type t1 = s1.GetType();

            Object[] atrybuty_s1 = t1.GetCustomAttributes(false);

            foreach (Object o in atrybuty_s1)
            {
                Console.WriteLine(((Student)o).nazwisko);
                Console.WriteLine(((Student)o).nazwaUczelni);
            }

            //////////////////////////////////////////////////////
            
            StudentZaoczny sz1 = new StudentZaoczny();
            Type t2 = sz1.GetType();

            Object[] atrybuty_sz1 = t2.GetCustomAttributes(true);
            
            foreach (Object o in atrybuty_sz1)
            {
                Console.WriteLine(((Student)o).nazwisko);
                Console.WriteLine(((Student)o).nazwaUczelni);
            }
        }
    }
}
