using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace consoleApp
{
    class PlayerClass
    {
        private List<string> names = new List<string>();
        private List<string> dateOfBirth = new List<string>();
        private List<int> playsCount = new List<int>();
        private List<int> penaltyCount = new List<int>();


        public PlayerClass(List<string> names, List<string> dateOfBirth, List<int> playsCount, List<int> penaltyCount)
        {
            this.names = names;
            this.dateOfBirth = dateOfBirth;
            this.playsCount = playsCount;
            this.penaltyCount = penaltyCount;
        }

        public void add(String name, String date, int plays, int penaltys)
        {
            names.Add(name);
            dateOfBirth.Add(date);
            playsCount.Add(plays);
            penaltyCount.Add(penaltys);
        }
        public void display()
        {
            if (names.Count > 0)
            {
                Console.WriteLine("ФИО        |         Дата рождения         |       Количество игр        |       Жёлтые карточки        |");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine("{0}                      {1}                         {2}                         {3}", names[i], dateOfBirth[i], playsCount[i], penaltyCount[i]);
                }
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }
        }
        public void quest()
        {
            if (names.Count > 0)
            {
                
            }
            else
            {
                Console.WriteLine("Список пуст!");
            }

        }
        //private static bool isValidQuestTime(string time)
        //{
        //    Regex checkTime = new Regex("^(?:[1]?[8-9]|2[0-3]):[0-5][0-9]$");
        //    return checkTime.IsMatch(time);
        //}
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> dateOfBirth = new List<string>();
            List<int> playsCount = new List<int>();
            List<int> penaltyCount = new List<int>();


            PlayerClass player = new PlayerClass(names, dateOfBirth, playsCount, penaltyCount);

            string name;
            string date;
            int plays;
            int penalty;

            string playsAcc;            // temp values for translating to int after checking on regex
            string penaltyAcc;

            bool dateCheck;
            bool playsCheck;
            bool penaltyCheck;

            string mode;

            while (true)
            {
                name = "";
                date = "";
                playsAcc = "";
                penaltyAcc = "";

                dateCheck = false;
                playsCheck = false;
                penaltyCheck = false;

                Console.WriteLine("Список(L) / Добавить(A) / Задание(Q)");

                mode = Console.ReadLine();
                if (mode == "l" || mode == "L")
                {
                    player.display();
                }
                else if (mode == "q" || mode == "Q")
                {
                    player.quest();
                }
                else if (mode == "a" || mode == "A")
                {
                    Console.WriteLine("Введите ФИО: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения: ");
                    while (!isValidDate(date))
                    {
                        date = Console.ReadLine();
                        if (!isValidDate(date))
                        {
                            Console.WriteLine("Введите корректную дату!");
                        }
                    }
                    Console.WriteLine("Введите количество игр: ");
                    while (!isValidPlays(playsAcc))
                    {
                        playsAcc = Console.ReadLine();
                        if (!isValidPlays(playsAcc))
                        {
                            Console.WriteLine("Введите корректное значение!");
                        }
                    }
                    Console.WriteLine("Введите количество жёлтых карточек: ");
                    while (!isValidPlays(penaltyAcc))
                    {
                        penaltyAcc = Console.ReadLine();
                        if (!isValidPlays(penaltyAcc))
                        {
                            Console.WriteLine("Введите корректное значение!");
                        }
                    }
                    plays = Convert.ToInt32(playsAcc);
                    penalty = Convert.ToInt32(penaltyAcc);

                    player.add(name, date, plays, penalty);
                    Console.WriteLine("Запись добавлена");
                }
                else
                {
                    Console.WriteLine("Неправильная команда!");
                }
            }
        }
        public static bool isValidDate(string time) // TODO: replace regex check
        {
            Regex checkTime = new Regex("^(?:[01]?[0-9]|2[0-2]).[0-1][0-2].[1-2][0-9][0-9][0-9]$");
            return checkTime.IsMatch(time);
        }

        public static bool isValidPlays(string cost)
        {
            Regex checkCost = new Regex("^\\d+$");
            return checkCost.IsMatch(cost);
        }

        public static bool isValidPenalty(string cost)
        {
            Regex checkCost = new Regex("^\\d+$");
            return checkCost.IsMatch(cost);
        }
    }
}