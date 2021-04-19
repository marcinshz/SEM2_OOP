namespace PD06._03
{
    class CD : Item
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public double Length { get; set; }

        public CD(double price, string title, string author, string publisher, double length) : base(price,title)
        {
            Author = author;
            Publisher = publisher;
            Length = length;
        }

    }
}
