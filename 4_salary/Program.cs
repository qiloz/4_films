using System.Text;

namespace salaryProgram
{
    
    //class Errors
    //{
    //    public void emptyError()
    //    {
    //        Console.WriteLine("[!] Список пуст!");
    //    }
    //    public void dateError() {
    //        Console.WriteLine("[!] Введена неправильная дата!");
    //    }
    //    public void commandError() { 
            
    //    }
    //}
    class SalaryClass
    {
        private List<String> namesOfProducts = new List<String>();
        private List<int> pricesOfProducts = new List<int>();
        private List<String> dateOfProduction = new List<String>();
        private List<int> expireDays = new List<int>();
        private List<int> countOfProducts = new List<int>();


         public SalaryClass(List<string> namesOfProducts, List<int> pricesOfProducts, List<string> dateOfProduction, List<int> expireDays, List<int> countOfProducts)
        {
            this.namesOfProducts = namesOfProducts;
            this.pricesOfProducts = pricesOfProducts;
            this.dateOfProduction = dateOfProduction;
            this.expireDays = expireDays;
            this.countOfProducts = countOfProducts;
        }

        public void add(String name, int price, String dateProduction, int expire, int count)
        {
            namesOfProducts.Add(name);
            pricesOfProducts.Add(price);
            dateOfProduction.Add(dateProduction);
            expireDays.Add(expire);
            countOfProducts.Add(count);
        }

        public void show()
        {
            if (namesOfProducts.Count > 0)
            {
                Console.WriteLine("Show list (placeholder)");
            }
            else
            {
                Console.WriteLine("[!] List is empty");
            }
        }

        public void specialShow()
        {
            if (namesOfProducts.Count > 0)
            {
                Console.WriteLine("Show list (placeholder)");
            }
            else
            {
                Console.WriteLine("[!] List is empty");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<String> name = new List<string>();
            List<int> price = new List<int>();
            List<String> dateProduction = new List<String>();
            List<int> expire = new List<int>();
            List<int> count = new List<int>();

            SalaryClass customer = new SalaryClass(name, price, dateProduction, expire, count);

            bool activeProg = true;

            while (activeProg)
            {
                string menuCommand;
                Console.WriteLine("\nГлавное меню:\nL - Список\nA - Добавить\nQ - Задание\nE - Выйти");
                menuCommand = (Console.ReadLine()).ToLower();

                switch (menuCommand)
                {
                    case "l":
                        customer.show();
                        break;
                    case "a":
                        string nameAdd = "";
                        int priceAdd = -1;
                        string dateAdd = "";
                        int expireDaysAdd = 0;
                        int countAdd = 0;

                        while (nameAdd.Length < 3)
                        {
                            Console.Write("Введите имя: ");
                            nameAdd = Console.ReadLine();
                            if (nameAdd.Length < 3)
                            {
                                Console.WriteLine("[!] Минимальное количество знаков для имени: 3, попробуйте ещё раз");
                            }
                        }
                        
                        while (priceAdd < 1)
                        {   
                            try
                            {
                                Console.Write("Введите цену: ");
                                priceAdd = Convert.ToInt32(Console.ReadLine());
                                if (priceAdd < 1)
                                {
                                    Console.WriteLine("[!] Минимальная цена: 0. Попробуйте ещё раз");
                                }
                            }
                            catch (System.FormatException e)
                            {
                                Console.WriteLine("[!] Недопустимые символы в цене. Попробуйте ещё раз");
                            }
                        }
                        bool dateSuccess = false;
                        while (!dateSuccess)
                        {
                            try
                            {
                                Console.Write("Введите дату: ");
                                dateAdd = Console.ReadLine();
                                DateTime dt = DateTime.Parse(dateAdd);
                                dateSuccess = true;
                            }
                            catch (System.FormatException e)
                            {
                                Console.WriteLine("[!] Недопустимая дата. Попробуйте ещё раз");
                            }
                        }

                        while (expireDaysAdd < 1)
                        {
                            try
                            {
                                Console.Write("Введите срок годности в днях: ");
                                expireDaysAdd = Convert.ToInt32(Console.ReadLine());
                                if (expireDaysAdd < 1)
                                {
                                    Console.WriteLine("[!] Минимальное количество дней: 1. Попробуйте ещё раз");
                                }
                            }
                            catch (System.FormatException e)
                            {
                                Console.WriteLine("[!] Недопустимые символы в сроке годности. Попробуйте ещё раз");
                            }
                        }

                        while (countAdd < 1)
                        {
                            try
                            {
                                Console.Write("Введите количество товара: ");
                                countAdd = Convert.ToInt32(Console.ReadLine());
                                if (countAdd < 1)
                                {
                                    Console.WriteLine("[!] Минимальное количество товара: 1. Попробуйте ещё раз");
                                }
                            }
                            catch (System.FormatException e)
                            {
                                Console.WriteLine("[!] Недопустимые символы в количестве товара. Попробуйте ещё раз");
                            }
                        }
                        Console.WriteLine("DEBUG: {0} {1} {2} {3} {4}", nameAdd, priceAdd, dateAdd, expireDaysAdd, countAdd);
                        Console.WriteLine("Запись добавлена!");
                        break;
                    case "q":
                        customer.specialShow();
                        break;
                    case "e":
                        activeProg = false;
                        break;
                    default: 
                        Console.WriteLine("Неправильная команда");
                        break;
                }
            }
        }
    }
}