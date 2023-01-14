using System;
using System.Collections.Generic;
using System.Text;


namespace consoleApp
{
    class FilmClass
    {
        private List<string> names;
        private List<string> dateOfstart;
        private List<string> price;


        private string name;
        private string dateOfStart;
        private int price;

        public FilmClass(string name, string dateOfStart, int price)
        {
            this.name = name;
            this.dateOfStart = dateOfStart;
            this.price = price;
        }

        public void display() {
            Console.WriteLine("{0}, {1}, {2}", name, dateOfStart, price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FilmClass films = new FilmClass("name", "01.01.01", 123);
            films.display();
        }
    }
}
