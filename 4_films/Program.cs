using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

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
            int avg = 0;
            if (names.Count > 0)
            {
                Console.WriteLine("Имя        |         Время начала сеанса         |       Цена        |");
                Console.WriteLine("----------------------------------------------------------------------");
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine("{0}                      {1}                         {2}        ", names[i], timeOfstart[i], prices[i]);
                    avg += prices[i];
                }
                avg = avg / prices.Count;
                Console.WriteLine("Средняя цена: {0}", avg);
            } else
            {
                Console.WriteLine("Список пуст!");
            }
        }
        public void quest()
        {
            int avg = 0;
            if (names.Count > 0)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    avg += prices[i];
                }
                avg = avg / prices.Count; // takes average number
                Console.WriteLine("Средняя цена: {0}", avg);

                Console.WriteLine("Имя        |         Время начала сеанса         |       Цена        |");
                Console.WriteLine("----------------------------------------------------------------------");
                for (int i = 0; i < names.Count; i++)
                {
                    if (isValidQuestTime(timeOfstart[i]) && prices[i] > avg)
                    {
                        Console.WriteLine("{0}                      {1}                         {2}        ", names[i], timeOfstart[i], prices[i]);
                    }
                }
            } else
            {
                Console.WriteLine("Список пуст!");
            }
            
        }
        private static bool isValidQuestTime(string time)
        {
            Regex checkTime = new Regex("^(?:[1]?[8-9]|2[0-3]):[0-5][0-9]$");
            return checkTime.IsMatch(time);
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
            string costAcc;
            int cost;

            bool timeCheck;
            bool costCheck;

            while (true)
            {
                time = "";
                costAcc = "";
                timeCheck = false;
                costCheck = false;

                Console.WriteLine("Список(L) / Добавить(A) / Задание(Q)");

                mode = Console.ReadLine();
                if (mode == "l" || mode == "L")
                {
                    film.display();
                }
                else if (mode == "q" || mode == "Q")
                {
                    film.quest();
                }
                else if (mode == "a" || mode == "A")
                {
                    Console.WriteLine("Введите имя фильма: ");
                    title = Console.ReadLine();
                    Console.WriteLine("Введите время начала сеанса: ");
                    while (!isValidTime(time))
                    {
                        time = Console.ReadLine();
                        if (!isValidTime(time))
                        {
                            Console.WriteLine("Введите корректное время!");
                        }
                    }
                    Console.WriteLine("Введите стоимость билета: ");
                    while (!isValidCost(costAcc))
                    {
                        costAcc = Console.ReadLine();
                        if (!isValidCost(costAcc))
                        {
                            Console.WriteLine("Введите корректную цену!");
                        }
                    }
                    cost = Convert.ToInt32(costAcc);
                    film.add(title, time, cost);
                    Console.WriteLine("Запись добавлена");
                } 
                else
                {
                    Console.WriteLine("Неправильная команда!");
                }
            }
        }
        public static bool isValidTime(string time)
        {
            Regex checkTime = new Regex("^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$");
            return checkTime.IsMatch(time);
        }
        public static bool isValidCost(string cost)
        {
            Regex checkCost = new Regex("^\\d+$");
            return checkCost.IsMatch(cost);
        }
    }
}