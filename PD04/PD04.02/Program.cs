using System;

namespace PD04._02
{
    abstract class Window
    {
        protected int punktx;
        protected int punkty;
        protected int width;
        protected int height;
        protected string name;

        public Window(int punktx, int punkty, int width, int height, string name)
        {
            this.punktx = punktx;
            this.punkty = punkty;
            this.width = width;
            this.height = height;
            this.name = name;
        }
        abstract public void DrawWindow();
    }
    class TextBox : Window
    {
        string content;
        public TextBox(string content, int punktx, int punkty, int width, int height, string name) : base(punktx,punkty,width,height,name)
        {
            this.content = content;
        }
        public override void DrawWindow()
        {
            Console.WriteLine($"Nazwa: {name}");
            Console.WriteLine($"Punkt zaczepienia:({punktx},{punkty})");
            Console.WriteLine($"Wymiary: {height} x {width}");
            Console.WriteLine($"Zawartość: {content}");
        }
    }
    class ListBox : Window
    {
        string[] list;
        public ListBox(string[] list, int punktx, int punkty, int width, int height, string name) : base(punktx, punkty, width, height, name)
        {
            this.list = list;
        }
        public void WypiszListe()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public override void DrawWindow()
        {
            Console.WriteLine($"Nazwa: {name}");
            Console.WriteLine($"Punkt zaczepienia:({punktx},{punkty})");
            Console.WriteLine($"Wymiary: {height} x {width}");
            Console.WriteLine("Lista:");
            WypiszListe();
        }
    }

    class Button : Window
    {
        bool clicked;
        public Button(bool clicked, int punktx, int punkty, int width, int height, string name) : base(punktx, punkty, width, height, name)
        {
            this.clicked = clicked;
        }
        public void ClickButton()
        {
            clicked = !clicked;
        }
        public override void DrawWindow()
        {
            Console.WriteLine($"Nazwa: {name}");
            Console.WriteLine($"Punkt zaczepienia:({punktx},{punkty})");
            Console.WriteLine($"Wymiary: {height} x {width}");
            Console.WriteLine($"Kliknięty: {clicked}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] l = { "asd", "gdaf", "dwgx" };
            ListBox lb = new ListBox(l, 1, 1, 500, 400, "lista");
            lb.DrawWindow();
        }
    }
}
