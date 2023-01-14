using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace consoleApp
{
    class FilmClass
    {
        private List<string> names = new List<string>();
        private List<string> timeOfstart = new List<string>();
        private List<int> prices = new List<int>();


        public FilmClass(List<string> names, List<string> timeOfStart, List<int> prices)
        {
            this.names = names;
            this.timeOfstart = timeOfStart;
            this.prices = prices;
        }

        public void add(String name, String time, int price)
        {
            names.Add(name);
            timeOfstart.Add(time);
            prices.Add(price);
        }
        public void display()
        {
            Console.WriteLine("Имя        |         Время начала сеанса         |       Цена        |");
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("{0}                      {1}                         {2}        ", names[i], timeOfstart[i], prices[i]);
            }
            
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> filmName = new List<string>();
            List<string> startTime = new List<string>();
            List<int> price = new List<int>();

        FilmClass film = new FilmClass(filmName, startTime, price);

            string mode;
            string title;
            string time;
            int cost;

            while (true)
            {
                
                Console.WriteLine("List(L) / Add(A)");
                mode = Console.ReadLine();
                if (mode == "l" || mode == "L")
                {
                    film.display();
                }
                else if (mode == "a" || mode == "A")
                {
                    Console.WriteLine("Введите имя фильма: ");
                    title = Console.ReadLine();
                    Console.WriteLine("Введите время начала сеанса: ");
                    time = Console.ReadLine();
                    Console.WriteLine("Введите стоимость билета: ");
                    cost = Convert.ToInt32(Console.ReadLine());
                    film.add(title, time, cost);
                } else
                {
                    Console.WriteLine("Неправильная команда");
                }

            }

        }


    }
}