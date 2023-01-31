namespace SpecialProgram
{
    class Special
    {
        private int code = new int();
        public int measure = new int();
        private string contact = new string("");
        private string dateOfConstruct = new string("");

        public Special() // default
        {
            Console.WriteLine("Значения по умолчанию установлены");
            code = 32;
            measure = 120;
            contact = "test";
            dateOfConstruct = "01.01.2001";
        }

        public Special(int code, int measure, string contact, string dateOfConstruct) // custom
        {
            this.code = code;
            this.measure = measure;
            this.contact = contact;
            this.dateOfConstruct = dateOfConstruct;
        }

        public void set_edit(int code, int measure, string contact, string dateOfConstruct)
        {
            this.code = code;
            this.measure = measure;
            this.contact = contact;
            this.dateOfConstruct = dateOfConstruct;
        }

        public void show()
        {
            Console.WriteLine("{0} {1} {2} {3}", code, measure, contact, dateOfConstruct);
        }

        public void compare(Special obj1)
        {
            Console.WriteLine("Сравнение класса: {0}", (this == obj1));
        }


        public void set()
        {
            Console.WriteLine("Введите код: ");
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер: ");
            measure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите заказчика техники: ");
            contact = Console.ReadLine();
            Console.WriteLine("Введите дату производства: ");
            dateOfConstruct = Console.ReadLine();
        }

        public static Special operator +(Special obj1, Special obj2)
        {
            Special tr = new Special();
            tr.measure = obj1.measure + obj2.measure;
            return tr;
        }

        public static Special operator -(Special obj1, Special obj2)
        {
            Special tr = new Special();
            tr.measure = obj1.measure - obj2.measure;
            return tr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int code = 10;
            int measure = 41;
            string contact = "test";
            string dateOfConstruct = "01.01.2001";

            Special test = new Special();
            Special auto = new Special(code, measure, contact, dateOfConstruct);
            Special auto1 = new Special(code, measure, contact, dateOfConstruct);
            Special auto2 = new Special(code, measure, contact, dateOfConstruct);

            auto.measure = 29;
            auto.set_edit(code, measure, contact, dateOfConstruct);

            test.show();
            auto.show();
            auto1.show();
            auto2.show();

            auto.set();


            test.show();
            auto.show();
            auto1.compare(auto1);

            Special outputPlus = auto + auto1;
            Console.WriteLine(outputPlus.measure);

            Special outputMinus = auto - auto1;
            Console.WriteLine(outputMinus.measure);
        }
    }
}
