namespace TransportProgram
{
    class Organisation
    {
        private int code = new int();
        public int count = new int();
        private string director = new string("");
        private string dateOfBuild = new string("");

        public Organisation()
        {
            Console.WriteLine("Значения по умолчанию установлены");
            code = 3;
            count = 100;
            director = "ФИО";
            dateOfBuild = "01.01.2001";
        }

        public Organisation(int code, int count, string director, string dateOfBuild) // custom
        {
            this.code = code;
            this.count = count;
            this.director = director;
            this.dateOfBuild = dateOfBuild;
        }

        public void show()
        {
            Console.WriteLine("{0} {1} {2} {3}", code, count, director, dateOfBuild);
        }

        public void compare(Organisation obj1, Organisation obj2)
        {
            Console.WriteLine("Сравнение класса: {0}", (this == obj1));
        }

        public void set_edit(int code, int count, string director, string dateOfBuild)
        {
            this.code = code;
            this.count = count;
            this.director = director;
            this.dateOfBuild = dateOfBuild;
        }

        public void set()
        {
            Console.WriteLine("Введите номер организации: ");
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество сотрудников: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО директора: ");
            director = Console.ReadLine();
            Console.WriteLine("Введите дату основания: ");
            dateOfBuild = Console.ReadLine();
        }

        public static Organisation operator +(Organisation obj1, Organisation obj2)
        {
            Organisation tr = new Organisation();
            tr.count = obj1.count + obj2.count;
            return tr;
        }

        public static Organisation operator -(Organisation obj1, Organisation obj2)
        {
            Organisation tr = new Organisation();
            tr.count = obj1.count - obj2.count;
            return tr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int code = 15;
            int count = 1;
            string director = "Имя Фамилия Отчество";
            string dateOfBuild = "12.12.2012";

            Organisation tempDefault = new Organisation();
            Organisation org1 = new Organisation(code, count, director, dateOfBuild);
            Organisation org2 = new Organisation(code, count, director, dateOfBuild);
            Organisation org3 = new Organisation(code, count, director, dateOfBuild);

            tempDefault.show();

            tempDefault.count = 90;
            org1.set_edit(code, count, director, dateOfBuild);

            org2.set();
            org1.show();
            org2.show();
            org3.show();

            org1.compare(org1, org2);

            Organisation outputPlus = org1 + org2;
            Console.WriteLine("count.org1 + count.org2 = {0} ", outputPlus.count);

            Organisation outputMinus = org2 - org1;
            Console.WriteLine("count.org2 - count.org1 = {0} ", outputMinus.count);
        }
    }
}
