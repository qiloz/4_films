namespace SpecialTransport
{
    abstract class SpecialTransportClass
    {
        public abstract string Type { get; set; }
        public abstract int Number { get; set; }
        public abstract string CodeName { get; set; }
        public abstract int FuelCapacity { get; set; }
        public abstract string ManufactureName { get; set; }
        public abstract string ConstructDate { get; set; }

        public virtual void show()
        {
            Console.Write("Тип машины: {0} | Номер: {1} | Имя машины: {2} | Потребление безина: {3} | Производитель: {4} | Дата производства: {5}", Type, Number, CodeName, FuelCapacity, ManufactureName, ConstructDate);
        }
    }

    class FireTransport : SpecialTransportClass
    {
        string serviceID = "Пожарная машина";
        int number;
        string codename;
        int fuelCapacity;
        string manufacture;
        string constructDate;
        public int countAlive = new int();

        public override string Type { get => serviceID; set => serviceID = value; }
        public override int Number { get => number; set => number = value; }
        public override string CodeName { get => codename; set => codename = value; }
        public override int FuelCapacity { get => fuelCapacity; set => fuelCapacity = value; }
        public override string ManufactureName { get => manufacture; set => manufacture = value; }
        public override string ConstructDate { get => constructDate; set => constructDate = value; }

        public FireTransport(int number, string codename, int fuelCapacity, string manufacture, string constructDate, int countAlive)
        {
            this.number = number;
            this.codename = codename;
            this.fuelCapacity = fuelCapacity;
            this.manufacture = manufacture;
            this.constructDate = constructDate;
            this.countAlive = countAlive;
        }

        public FireTransport()
        {

            number = 0;
            codename = "UNKNOWN";
            fuelCapacity = 0;
            manufacture = "NO_VENDOR";
            constructDate = "01.01.1990";
            countAlive = 0;
        }

        public override void show()
        {
            base.show();
            Console.Write(" | Количество спасённых: {0}", countAlive);
        }
    }

    class FireTransportEq : FireTransport
    {
        public int literCapacity = new int();

        public FireTransportEq(int number, string codename, int fuelCapacity, string manufacture, string constructDate, int countAlive, int literCapacity) : base(number, codename, fuelCapacity, manufacture, constructDate, countAlive)
        {
            this.literCapacity = literCapacity;
        }

        public FireTransportEq()
        {
            literCapacity = 1;
        }

        public override void show()
        {
            base.show();
            Console.Write(" | Вместимость воды: {0} \n", literCapacity);
        }
    }

    class FireLadderTransport : SpecialTransportClass
    {
        string serviceID = "Пожарная лестница";

        int number;
        string codename;
        int fuelCapacity;
        string manufacture;
        string constructDate;
        public int maxLength = new int();

        public override string Type { get => serviceID; set => serviceID = value; }
        public override int Number { get => number; set => number = value; }
        public override string CodeName { get => codename; set => codename = value; }
        public override int FuelCapacity { get => fuelCapacity; set => fuelCapacity = value; }
        public override string ManufactureName { get => manufacture; set => manufacture = value; }
        public override string ConstructDate { get => constructDate; set => constructDate = value; }

        public FireLadderTransport(int number, string codename, int fuelCapacity, string manufacture, string constructDate, int maxLength)
        {
            this.number = number;
            this.codename = codename;
            this.fuelCapacity = fuelCapacity;
            this.manufacture = manufacture;
            this.constructDate = constructDate;
            this.maxLength = maxLength;
        }

        public FireLadderTransport()
        {
            number = 0;
            codename = "UNKNOWN";
            fuelCapacity = 0;
            manufacture = "NO_VENDOR";
            constructDate = "01.01.1990";
            maxLength = 1;
        }

        public override void show()
        {
            base.show();
            Console.Write(" | Максимальная длина лестницы: {0}", maxLength);
        }
    }

    class FireLadderTransportEq : FireLadderTransport
    {
        public int mileage = new int();

        public FireLadderTransportEq(int number, string codename, int fuelCapacity, string manufacture, string constructDate, int maxLength, int mileage) : base(number, codename, fuelCapacity, manufacture, constructDate, maxLength)
        {
            this.mileage = mileage;
        }

        public FireLadderTransportEq()
        {
            mileage = 1;
        }

        public override void show()
        {
            base.show();
            Console.Write(" | Пробег: {0} \n", mileage);
        }
    }

    class ParamedicTransport : SpecialTransportClass
    {
        string serviceID = "Скорая помощь";

        int number;
        string codename;
        int fuelCapacity;
        string manufacture;
        string constructDate;
        public int maxSpeed = new int();

        public override string Type { get => serviceID; set => serviceID = value; }
        public override int Number { get => number; set => number = value; }
        public override string CodeName { get => codename; set => codename = value; }
        public override int FuelCapacity { get => fuelCapacity; set => fuelCapacity = value; }
        public override string ManufactureName { get => manufacture; set => manufacture = value; }
        public override string ConstructDate { get => constructDate; set => constructDate = value; }

        public ParamedicTransport(int number, string codename, int fuelCapacity, string manufacture, string constructDate, int maxSpeed)
        {
            this.number = number;
            this.codename = codename;
            this.fuelCapacity = fuelCapacity;
            this.manufacture = manufacture;
            this.constructDate = constructDate;
            this.maxSpeed = maxSpeed;
        }

        public ParamedicTransport()
        {
            number = 0;
            codename = "UNKNOWN";
            fuelCapacity = 0;
            manufacture = "NO_VENDOR";
            constructDate = "01.01.1990";
            maxSpeed = 1;
        }

        public override void show()
        {
            base.show();
            Console.Write(" | Максимальная скорость: {0}", maxSpeed);
        }
    }

    class ParamedicTransportEq : ParamedicTransport
    {
        public int oxygen = new int();

        public ParamedicTransportEq(int number, string codename, int fuelCapacity, string manufacture, string constructDate, int maxSpeed, int oxygen) : base(number, codename, fuelCapacity, manufacture, constructDate, maxSpeed)
        {
            this.oxygen = oxygen;
        }

        public ParamedicTransportEq()
        {
            oxygen = 1;
        }

        public override void show()
        {
            base.show();
            Console.Write(" | Запас кислорода: {0} \n", oxygen);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"./input.txt");
            int number = lines.GetLength(0);

            int countFire = 0;
            int countFireLadder = 0;
            int countParamedics = 0;

            string parserMode = "";

            foreach (string line in lines)
            {
                if (line == "[Fire]")
                {
                    parserMode = "fire";
                    continue;
                }
                else if (line == "[Fire_ladder]")
                {
                    parserMode = "fire_ladder";
                    continue;
                }
                else if (line == "[Paramedics]")
                {
                    parserMode = "paramedic";
                    continue;
                }

                switch (parserMode)
                {
                    case "fire":
                        countFire++;
                        break;
                    case "fire_ladder":
                        countFireLadder++;
                        break;
                    case "paramedic":
                        countParamedics++;
                        break;
                }
            }

            FireTransportEq fireTransportDefault = new FireTransportEq();
            FireTransportEq[] fireTransport = new FireTransportEq[countFire];
         
            for (int i = 0; i < countFire; ++i)
            {
                fireTransport[i] = fireTransportDefault;
            }

            FireLadderTransportEq fireLadderTransportDefault = new FireLadderTransportEq();
            FireLadderTransportEq[] fireLadderTransport = new FireLadderTransportEq[countFireLadder];

            for (int i = 0; i < countFireLadder; ++i)
            {
                fireLadderTransport[i] = fireLadderTransportDefault;
            }

            ParamedicTransportEq paramedicTransportDefault = new ParamedicTransportEq();
            ParamedicTransportEq[] paramedicTransport = new ParamedicTransportEq[countParamedics];

            for (int i = 0; i < countParamedics; ++i)
            {
                paramedicTransport[i] = paramedicTransportDefault;
            }

            int indexArray = 0;
            foreach (string line in lines)
            {
                if (line == "[Fire]")
                {
                    parserMode = "fire";
                    indexArray = 0;
                    continue;
                }
                else if (line == "[Fire_ladder]")
                {
                    parserMode = "fire_ladder";
                    indexArray = 0;
                    continue;
                }
                else if (line == "[Paramedics]")
                {
                    parserMode = "paramedic";
                    indexArray = 0;
                    continue;
                }

                string[] elements = line.Split(' ');
                switch (parserMode)
                {
                    case "fire":
                        try
                        {
                            fireTransport[indexArray].Number = Convert.ToInt32(elements[0]);
                            fireTransport[indexArray].CodeName = elements[1];
                            fireTransport[indexArray].FuelCapacity = Convert.ToInt32(elements[2]);
                            fireTransport[indexArray].ManufactureName = elements[3];
                            fireTransport[indexArray].ConstructDate = elements[4];
                            fireTransport[indexArray].countAlive = Convert.ToInt32(elements[5]);
                            fireTransport[indexArray].literCapacity = Convert.ToInt32(elements[6]);

                            fireTransport[indexArray].show();

                            indexArray++;
                        }
                        catch
                        {
                            fireTransport[indexArray].Number = Convert.ToInt32(elements[0]);
                            Console.WriteLine(elements[4]);
                            Console.WriteLine("ОШИБКА: Элемент для fireTransport [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }

                        break;
                    case "fire_ladder":
                        try
                        {
                            fireLadderTransport[indexArray].Number = Convert.ToInt32(elements[0]);
                            fireLadderTransport[indexArray].CodeName = elements[1];
                            fireLadderTransport[indexArray].FuelCapacity = Convert.ToInt32(elements[2]);
                            fireLadderTransport[indexArray].ManufactureName = elements[3];
                            fireLadderTransport[indexArray].ConstructDate = elements[4];
                            fireLadderTransport[indexArray].maxLength = Convert.ToInt32(elements[5]);
                            fireLadderTransport[indexArray].mileage = Convert.ToInt32(elements[6]);

                            fireLadderTransport[indexArray].show();

                            indexArray++;
                        }
                        catch
                        {
                            Console.WriteLine("ОШИБКА: Элемент для fireLadderTransport [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }
                        break;
                    case "paramedic":
                        try
                        {
                            paramedicTransport[indexArray].Number = Convert.ToInt32(elements[0]);
                            paramedicTransport[indexArray].CodeName = elements[1];
                            paramedicTransport[indexArray].FuelCapacity = Convert.ToInt32(elements[2]);
                            paramedicTransport[indexArray].ManufactureName = elements[3];
                            paramedicTransport[indexArray].ConstructDate = elements[4];
                            paramedicTransport[indexArray].maxSpeed = Convert.ToInt32(elements[5]);
                            paramedicTransport[indexArray].oxygen = Convert.ToInt32(elements[6]);

                            fireLadderTransport[indexArray].show();

                            indexArray++;
                        }
                        catch
                        {
                            Console.WriteLine("ОШИБКА: Элемент для paramedicTransport [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }
                        break;
                }
            }
            Console.Read();
        }
    }
}