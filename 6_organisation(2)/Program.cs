namespace OrganisationProgram
{
    abstract class Organisation
    {
        public abstract int Code { get; set; }

        public abstract string Name { get; set; }
        public abstract int CountPersons { get; set; }
        public abstract string Director { get; set; }
        public abstract string DateOfAppear { get; set; }


        public abstract void typeOfOrganisation();

        public virtual void show()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", Code, Name, CountPersons, Director, DateOfAppear);
        }
    }

    class Finance : Organisation
    {
        string OrganisationID = "Финансовая";
        int code;
        string name;
        int persons;
        string directorName;
        string dateOfappear;
        public int annual = new int();

        public override int Code
        {
            get => code;
            set => code = value;
        }
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public override int CountPersons
        {
            get => persons;
            set => persons = value;
        }

        public override string Director
        {
            get => directorName;
            set => directorName = value;
        }

        public override string DateOfAppear
        {
            get => dateOfappear;
            set => dateOfappear = value;
        }

        public Finance()
        {
            code = 0;
            name = "UNKNOWN";
            persons = 1;
            directorName = "UNKNOWN";
            dateOfappear = "UNKNOWN";
            annual = 0;
        }

        public Finance(int code, string name, int persons, string directorName, string dateOfappear, int annual)
        {
            this.code = code;
            this.name = name;
            this.persons = persons;
            this.directorName = directorName;
            this.dateOfappear = dateOfappear;
            this.annual = annual;
        }

        public override void typeOfOrganisation()
        {
            Console.WriteLine("Тип организации: {0}", OrganisationID);
        }

        public override void show()
        {
            typeOfOrganisation();
            Console.WriteLine("Код организации: {0} | Имя организации: {1} | Количество персонала: {2} | Директор: {3} | Дата регистрации: {4} | Годовой оборот: {5}", code, name, persons, directorName, dateOfappear, annual);
        }
    }

    class Bank : Organisation
    {
        string OrganisationID = "Банк";
        int code;
        string name;
        int persons;
        string directorName;
        string dateOfappear;
        public int annual = new int();
        public int clientsCount = new int();

        public override int Code
        {
            get => code;
            set => code = value;
        }
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public override int CountPersons
        {
            get => persons;
            set => persons = value;
        }

        public override string Director
        {
            get => directorName;
            set => directorName = value;
        }

        public override string DateOfAppear
        {
            get => dateOfappear;
            set => dateOfappear = value;
        }

        public Bank()
        {
            code = 0;
            name = "UNKNOWN";
            persons = 1;
            directorName = "UNKNOWN";
            dateOfappear = "UNKNOWN";
            annual = 0;
            clientsCount = 0;
        }

        public Bank(int code, string name, int persons, string directorName, string dateOfappear, int annual, int clientsCount)
        {
            this.code = code;
            this.name = name;
            this.persons = persons;
            this.directorName = directorName;
            this.dateOfappear = dateOfappear;
            this.annual = annual;
            this.clientsCount = clientsCount;
        }

        public override void typeOfOrganisation()
        {
            Console.WriteLine("Тип организации: {0}", OrganisationID);
        }

        public override void show()
        {
            typeOfOrganisation();
            Console.WriteLine("Код организации: {0} | Имя организации: {1} | Количество персонала: {2} | Директор: {3} | Дата регистрации: {4} | Годовой оборот: {5} | Количество клиентов: {6}", code, name, persons, directorName, dateOfappear, annual, clientsCount);
        }
    }

    class Factory : Organisation
    {
        string OrganisationID = "Завод";
        int code;
        string name;
        int persons;
        string directorName;
        string dateOfappear;
        public string profileOfproduct = new string("");

        public override int Code
        {
            get => code;
            set => code = value;
        }
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public override int CountPersons
        {
            get => persons;
            set => persons = value;
        }

        public override string Director
        {
            get => directorName;
            set => directorName = value;
        }

        public override string DateOfAppear
        {
            get => dateOfappear;
            set => dateOfappear = value;
        }

        public Factory()
        {
            code = 0;
            name = "UNKNOWN";
            persons = 1;
            directorName = "UNKNOWN";
            dateOfappear = "UNKNOWN";
            profileOfproduct = "UNKNOWN";
        }

        public Factory(int code, string name, int persons, string directorName, string dateOfappear, string profileOfproduct)
        {
            this.code = code;
            this.name = name;
            this.persons = persons;
            this.directorName = directorName;
            this.dateOfappear = dateOfappear;
            this.profileOfproduct = profileOfproduct;
        }

        public override void typeOfOrganisation()
        {
            Console.WriteLine("Тип организации: {0}", OrganisationID);
        }

        public override void show()
        {
            typeOfOrganisation();
            Console.WriteLine("Код организации: {0} | Имя организации: {1} | Количество персонала: {2} | Директор: {3} | Дата регистрации: {4} | Профиль направления: {5} ", code, name, persons, directorName, dateOfappear, profileOfproduct);
        }
    }

    class FinanceInfo : Finance
    {
        string OrganisationID = "Финансовая";
        int code;
        string name;
        int persons;
        string directorName;
        string dateOfappear;
        public int salary = new int();


        public FinanceInfo()
        {
            salary = 0;
        }

        public FinanceInfo(int code, string name, int persons, string directorName, string dateOfappear, int annual, int salary) : base(code, name, persons, directorName, dateOfappear, annual)
        {
            this.code = code;
            this.name = name;
            this.persons = persons;
            this.directorName = directorName;
            this.dateOfappear = dateOfappear;
            this.annual = annual;
            this.salary = salary;
        }

        public override void show()
        {
            typeOfOrganisation();
            Console.WriteLine("Количество продаж: {0}", salary);
        }
    }

    class BankInfo : Bank
    {
        string OrganisationID = "Банк";
        int code;
        string name;
        int persons;
        string directorName;
        string dateOfappear;
        public int creditsGiven = new int();


        public BankInfo()
        {
            creditsGiven = 0;
        }

        public BankInfo(int code, string name, int persons, string directorName, string dateOfappear, int annual, int clientsCount, int creditsGiven) : base(code, name, persons, directorName, dateOfappear, annual, clientsCount)
        {
            this.code = code;
            this.name = name;
            this.persons = persons;
            this.directorName = directorName;
            this.dateOfappear = dateOfappear;
            this.annual = annual;
            this.creditsGiven = creditsGiven;
        }

        public override void show()
        {
            typeOfOrganisation();
            Console.WriteLine("Годовой оборот: {0} | Выдано кредитов: {1}", annual, creditsGiven);
        }
    }

    class FactoryInfo : Factory
    {
        string OrganisationID = "Завод";
        int code;
        string name;
        int persons;
        string directorName;
        string dateOfappear;
        int resourceCount = new int();

        public FactoryInfo()
        {
            resourceCount = 0;
        }

        public FactoryInfo(int code, string name, int persons, string directorName, string dateOfappear, string profileOfproduct, int resourceCount) : base(code, name, persons, directorName, dateOfappear, profileOfproduct)
        {
            this.code = code;
            this.name = name;
            this.persons = persons;
            this.directorName = directorName;
            this.dateOfappear = dateOfappear;
            this.profileOfproduct = profileOfproduct;
            this.resourceCount = resourceCount;
        }

        public override void show()
        {
            typeOfOrganisation();
            Console.WriteLine("Профиль направления: {0} | Количество ресурсов: {1} ", profileOfproduct, resourceCount);
        }
    }



    class Program
    {
        public static void Main(String[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"./input.txt");
            int number = lines.GetLength(0);

            int countFinance = 0;
            int countBank = 0;
            int countFactory = 0;

            string parserMode = "";

            foreach (string line in lines)
            {
                if (line == "[Finance]")
                {
                    parserMode = "finance";
                    continue;
                }
                else if (line == "[Bank]")
                {
                    parserMode = "bank";
                    continue;
                }
                else if (line == "[Factory]")
                {
                    parserMode = "factory";
                    continue;
                }

                switch (parserMode)
                {
                    case "finance":
                        countFinance++;
                        break;
                    case "bank":
                        countBank++;
                        break;
                    case "factory":
                        countFactory++;
                        break;
                }
            }


            Finance financesDefault = new Finance();
            FinanceInfo financesInfoDefault = new FinanceInfo();

            Finance[] finances = new Finance[countFinance];
            FinanceInfo[] financesInfo = new FinanceInfo[countFinance];
            for (int i = 0; i < countFinance; ++i)
            {
                finances[i] = financesDefault;
                financesInfo[i] = financesInfoDefault;
            }

            Bank banksDefault = new Bank();
            BankInfo banksInfoDefault = new BankInfo();

            Bank[] banks = new Bank[countBank];
            BankInfo[] banksInfo = new BankInfo[countBank];

            for (int i = 0; i < countBank; ++i)
            {
                banks[i] = banksDefault;
                banksInfo[i] = banksInfoDefault;
            }


            Factory factorysDefault = new Factory();
            FactoryInfo factorysInfoDefault = new FactoryInfo();

            Factory[] factoryies = new Factory[countFactory];
            Factory[] factoryiesInfo = new FactoryInfo[countFactory];

            for (int i = 0; i < countFactory; ++i)
            {
                factoryies[i] = factorysDefault;
            }

            // working with classes 
            int indexArray = 0;
            foreach (string line in lines)
            {
                if (line == "[Finance]")
                {
                    parserMode = "finance";
                    indexArray = 0;
                    continue;
                }
                else if (line == "[Bank]")
                {
                    parserMode = "bank";
                    indexArray = 0;
                    continue;
                }
                else if (line == "[Factory]")
                {
                    parserMode = "factory";
                    indexArray = 0;
                    continue;
                }

                string[] elements = line.Split(' ');
                switch (parserMode)
                {
                    case "finance":
                        try
                        {
                            finances[indexArray].Code = Convert.ToInt32(elements[0]);
                            finances[indexArray].Name = elements[1];
                            finances[indexArray].CountPersons = Convert.ToInt32(elements[2]);
                            finances[indexArray].Director = elements[3];
                            finances[indexArray].DateOfAppear = elements[4];
                            finances[indexArray].annual = Convert.ToInt32(elements[5]);
                            financesInfo[indexArray].salary = Convert.ToInt32(elements[6]);

                            finances[indexArray].show();
                            financesInfo[indexArray].show();

                            indexArray++;
                        }
                        catch
                        {
                            Console.WriteLine("ОШИБКА: Элемент для finance [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }

                        break;
                    case "bank":
                        try
                        {
                            banks[indexArray].Code = Convert.ToInt32(elements[0]);
                            banks[indexArray].Name = elements[1];
                            banks[indexArray].CountPersons = Convert.ToInt32(elements[2]);
                            banks[indexArray].Director = elements[3];
                            banks[indexArray].DateOfAppear = elements[4];
                            banksInfo[indexArray].annual = Convert.ToInt32(elements[5]);
                            banksInfo[indexArray].creditsGiven = Convert.ToInt32(elements[6]);


                            banks[indexArray].show();
                            banksInfo[indexArray].show();

                            indexArray++;
                        }
                        catch
                        {
                            Console.WriteLine("ОШИБКА: Элемент для bank [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }
                        break;
                    case "factory":
                        try
                        {
                            factoryies[indexArray].Code = Convert.ToInt32(elements[0]);
                            factoryies[indexArray].Name = elements[1];
                            factoryies[indexArray].CountPersons = Convert.ToInt32(elements[2]);
                            factoryies[indexArray].Director = elements[3];
                            factoryies[indexArray].DateOfAppear = elements[4];
                            factoryies[indexArray].profileOfproduct = elements[5];

                            factoryies[indexArray].show();

                            indexArray++;
                        }
                        catch
                        {
                            Console.WriteLine("ОШИБКА: Элемент для express [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }
                        break;
                }
            }
        }
    }
}