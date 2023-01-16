namespace TransportProgram
{
    class Transport
    {
        private int code = new int();
        public int measure = new int();
        private string manufacture = new string("");
        private string dateOfConstruct = new string("");

        public Transport() // default
        {
            Console.WriteLine("Значения по умолчанию установлены");
            code = 1;
            measure = 100;
            manufacture = "test";
            dateOfConstruct = "01.01.2001";
        }

        public Transport(int code, int measure, string manufacture, string dateOfConstruct) // custom
        {
            this.code = code;
            this.measure = measure;
            this.manufacture = manufacture;
            this.dateOfConstruct = dateOfConstruct;
        }

        public void show() {
            Console.WriteLine("{0} {1} {2} {3}", code, measure, manufacture, dateOfConstruct);
        }

        public void compare()
        {
            Console.WriteLine("");
        }

        public void set_edit(int code, int measure, string manufacture, string dateOfConstruct)
        {
            this.code = code;
            this.measure = measure;
            this.manufacture = manufacture;
            this.dateOfConstruct = dateOfConstruct;
        }

        public void set()
        {
            Console.WriteLine("Введите код: ");
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер: ");
            measure = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите производителя: ");
            manufacture = Console.ReadLine();
            Console.WriteLine("Введите дату производства: ");
            dateOfConstruct = Console.ReadLine();
        }

        public static Transport operator +(Transport obj1, Transport obj2)
        {
            Transport tr = new Transport();
            tr.measure = obj1.measure + obj2.measure;
            return tr;
        }

        public static Transport operator -(Transport obj1, Transport obj2)
        {
            Transport tr = new Transport();
            tr.measure = obj1.measure - obj2.measure;
            return tr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int code = 2;
            int measure = 4;
            string manufacture = "test";
            string dateOfConstruct = "01.01.2001";

            Transport test = new Transport();
            Transport trc = new Transport(code, measure, manufacture, dateOfConstruct);
            Transport trc1 = new Transport(code, measure, manufacture, dateOfConstruct);
            Transport trc2 = new Transport(code, measure, manufacture, dateOfConstruct);

            trc.measure = 12;
            trc.set_edit(code, measure, manufacture, dateOfConstruct);

            test.show();
            trc.show();
            trc1.show();
            trc2.show();

            trc.set();
            //trc1.set();
            //trc2.set();

            test.show();
            trc.show();
            trc1.show();
            trc2.show();

            Transport outputPlus = trc + trc1;
            Console.WriteLine(outputPlus.measure);

            Transport outputMinus = trc - trc1;
            Console.WriteLine(outputMinus.measure);
        }
    }
}