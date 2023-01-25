using System;
namespace TransportProgram
{
    abstract class Transport {
        public abstract int Code  { get; set; }
        public abstract int Measure { get; set; }
        public abstract string Manufacture { get; set; } 
        public abstract string DateOfConstruct { get; set;} 

        
        public abstract void typeOfTransport();
        
        public virtual void show(){
           Console.WriteLine("{0} {1} {2} {3}", Code, Measure, Manufacture, DateOfConstruct); 
        }
    }

    class Train : Transport {
        string transportID = "Поезд";
        int code;
        int measure;
        string manufacture;
        string dateOfConstruct;
        public int speed = new int();

        public override int Code {
            get => code;
            set => code = value;
        }

        public override int Measure {
            get => measure;
            set => measure = value;
        }

        public override string Manufacture {
            get => manufacture;
            set => manufacture = value;
        }

        public override string DateOfConstruct {
            get => dateOfConstruct;
            set => dateOfConstruct = value;
        }

        public Train() {
            code = 0;
            measure = 0;
            manufacture = "UNKNOWN";
            dateOfConstruct = "UNKNWOWN";
            speed = 0;
        }

        public Train(int code, int measure, string manufacture, string dateOfConstruct, int speed ) {
           this.code = code;
           this.measure = measure;
           this.manufacture = manufacture;
           this.dateOfConstruct = dateOfConstruct;
           this.speed = speed;
        }

        public override void typeOfTransport() {
            Console.WriteLine("Тип: {0}", transportID);
        }
        
        public override void show(){
            typeOfTransport();
            Console.WriteLine("Код: {0} | Длина: {1} | Производитель: {2} | Дата производства: {3} | Скорость: {4}", code, measure, manufacture, dateOfConstruct, speed); 
        }
    }

class Auto : Transport {
        string transportID = "Авто";
        int code;
        int measure;
        string manufacture;
        string dateOfConstruct;
        public int speed = new int();
        public int power = new int();

        public override int Code {
            get => code;
            set => code = value;
        }

        public override int Measure {
            get => measure;
            set => measure = value;
        }

        public override string Manufacture {
            get => manufacture;
            set => manufacture = value;
        }

        public override string DateOfConstruct {
            get => dateOfConstruct;
            set => dateOfConstruct = value;
        }

        public Auto() {
            code = 0;
            measure = 0;
            manufacture = "UNKNOWN";
            dateOfConstruct = "UNKNWOWN";
            speed = 0;
            power = 0;
        }

        public Auto(int code, int measure, string manufacture, string dateOfConstruct, int speed, int power) {
           this.code = code;
           this.measure = measure;
           this.manufacture = manufacture;
           this.dateOfConstruct = dateOfConstruct;
           this.speed = speed;
           this.power = power;
        }

        public override void typeOfTransport() {
            Console.WriteLine("Тип: {0}", transportID);
        }

        public override void show(){
            typeOfTransport();
            Console.WriteLine("Код: {0} | Длина: {1} | Производитель: {2} | Дата производства: {3} | Скорость: {4} | Мощность: {5}", code, measure, manufacture, dateOfConstruct, speed, power); 

        }
    }
class Express : Transport {
        string transportID = "Экспресс";
        int code;
        int measure;
        string manufacture;
        string dateOfConstruct;
        public int speed = new int();
        public int consumption = new int();



        public override int Code {
            get => code;
            set => code = value;
        }

        public override int Measure {
            get => measure;
            set => measure = value;
        }

        public override string Manufacture {
            get => manufacture;
            set => manufacture = value;
        }

        public override string DateOfConstruct {
            get => dateOfConstruct;
            set => dateOfConstruct = value;
        }

        public Express() {
            code = 0;
            measure = 0;
            manufacture = "UNKNOWN";
            dateOfConstruct = "UNKNWOWN";
            speed = 0;
            consumption = 0;
        }

        public Express(int code, int measure, string manufacture, string dateOfConstruct, int speed, int consumption) {
           this.code = code;
           this.measure = measure;
           this.manufacture = manufacture;
           this.dateOfConstruct = dateOfConstruct;
           this.speed = speed;
           this.consumption = consumption;
        }

        public override void typeOfTransport() {
            Console.WriteLine("Тип: {0}", transportID);
        }

        public override void show(){
            typeOfTransport();
            Console.WriteLine("Код: {0} | Длина: {1} | Производитель: {2} | Дата производства: {3} | Скорость: {4} | Потребление: {5}\n", code, measure, manufacture, dateOfConstruct, speed, consumption); 
        }
    }

    class TrainDetails : Train {
        string transportID = "Поезд";
        int code;
        int measure;
        string manufacture;
        string dateOfConstruct;
        public string engine = new string("");

        public TrainDetails(){
           engine = "UNKNOWN"; 
        }

        public TrainDetails(int code, int measure, string manufacture, string dateOfConstruct, int speed, string engine) : base (code, measure, manufacture, dateOfConstruct, speed) {
           this.code = code;
           this.measure = measure;
           this.manufacture = manufacture;
           this.dateOfConstruct = dateOfConstruct;
           this.speed = speed;
           this.engine = engine;
        }

        public override void show(){
            Console.WriteLine("Двигатель: {0}\n", engine); 
        }
    }
    class AutoEquipment : Auto {
        string transportID = "Авто";
        int code;
        int measure;
        string manufacture;
        string dateOfConstruct;
        public string equipment = new string("");

        public AutoEquipment() {
            equipment = "UNKNOWN";
        }
        
        public AutoEquipment(int code, int measure, string manufacture, string dateOfConstruct, int speed, int power, string equipment) : base (code, measure, manufacture, dateOfConstruct, speed, power) {
           this.code = code;
           this.measure = measure;
           this.manufacture = manufacture;
           this.dateOfConstruct = dateOfConstruct;
           this.speed = speed;
           this.power = power;
           this.equipment = equipment;
        }

        public override void typeOfTransport() {
            Console.WriteLine("Тип: {0}", transportID);
        }

        public override void show(){
            Console.WriteLine("Комплектация: {0}\n", equipment); 

        }
    }


    class Program {
        public static void Main(String[] args){
            string[] lines = System.IO.File.ReadAllLines(@"./input.txt");
            int number = lines.GetLength(0);

            int countTrains = 0;
            int countCars = 0;
            int countExpress = 0;

            string parserMode = "";
            
            // count lines
            foreach(string line in lines) {
                if (line == "[Trains]") {
                    parserMode = "trains";
                    continue;
                } else if (line == "[Cars]") {
                    parserMode = "cars";
                    continue;
                } else if (line == "[Express]") {
                    parserMode = "express";
                    continue;
                }

                switch (parserMode){
                    case "trains":
                        countTrains++; 
                        break;
                    case "cars":
                        countCars++; 
                        break;
                    case "express":
                        countExpress++; 
                        break;
                }
            }

            
            Train trainsDefault = new Train();
            TrainDetails detailsDefault = new TrainDetails();

            Train[] trains = new Train[countTrains];
            TrainDetails[] details = new TrainDetails[countTrains];
            for (int i = 0; i < countTrains; ++i) {
                trains[i] = trainsDefault;
                details[i] = detailsDefault;
            }

            Auto autosDefault = new Auto();
            AutoEquipment equipmentDefault = new AutoEquipment();

            Auto[] autos = new Auto[countCars];
            AutoEquipment[] equipment = new AutoEquipment[countCars];

            for (int i = 0; i < countCars; ++i) {
                autos[i] = autosDefault;
                equipment[i] = equipmentDefault;
            }

            Express expressDefault = new Express();
            Express[] express = new Express[countExpress];
            
            for (int i = 0; i < countExpress; ++i) {
                express[i] = expressDefault;
            }

            // working with classes 
            int indexArray = 0;
            foreach(string line in lines) {
                if (line == "[Trains]") {
                    parserMode = "trains";
                    indexArray = 0;
                    continue;
                } else if (line == "[Cars]") {
                    parserMode = "cars";
                    indexArray = 0;
                    continue;
                } else if (line == "[Express]") {
                    parserMode = "express";
                    indexArray = 0;
                    continue;
                }

                string [] elements = line.Split(' ');
                switch (parserMode){
                    case "trains":
                        try
                        {
                        trains[indexArray].Code = Convert.ToInt32(elements[0]);
                        trains[indexArray].Measure = Convert.ToInt32(elements[1]);
                        trains[indexArray].Manufacture = elements[2];
                        trains[indexArray].DateOfConstruct = elements[3];
                        trains[indexArray].speed = Convert.ToInt32(elements[4]);
                        details[indexArray].engine = elements[5];

                        trains[indexArray].show();
                        details[indexArray].show();

                        indexArray++;
                        }
                        catch
                        {
                            Console.WriteLine("ОШИБКА: Элемент для trains [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }
                        
                        break;
                    case "cars":
                        try 
                        {
                        autos[indexArray].Code = Convert.ToInt32(elements[0]);
                        autos[indexArray].Measure = Convert.ToInt32(elements[1]);
                        autos[indexArray].Manufacture = elements[2];
                        autos[indexArray].DateOfConstruct = elements[3];
                        autos[indexArray].speed = Convert.ToInt32(elements[4]);
                        autos[indexArray].power = Convert.ToInt32(elements[5]);
                        equipment[indexArray].equipment = elements[6];

                        autos[indexArray].show();
                        equipment[indexArray].show();
                       
                        indexArray++;
                        }
                        catch
                        {
                            Console.WriteLine("ОШИБКА: Элемент для cars [позиция: {0}] в текстовом документе отсутствует или введён некорректно", indexArray);
                        }
                        break;
                    case "express":
                        try
                        {
                        express[indexArray].Code = Convert.ToInt32(elements[0]);
                        express[indexArray].Measure = Convert.ToInt32(elements[1]);
                        express[indexArray].Manufacture = elements[2];
                        express[indexArray].DateOfConstruct = elements[3];
                        express[indexArray].speed = Convert.ToInt32(elements[4]);
                        express[indexArray].consumption = Convert.ToInt32(elements[5]);

                        express[indexArray].show();

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

            
            //Train testTrain = new Train(1, 2, "helloworld", "4", 5);
            //Details detail = new Details(1, 2, "helloworld", "4", 5, "test");
            //Auto testAuto = new Auto(2, 10, "helloworld", "4", 5, 6);
            //Equipment equipment = new Equipment(2, 10, "helloworld", "4", 5, 6, "Комфорт");
            //Express testExpress = new Express(3, 122, "helloworld", "4", 5, 6);
            // testTrain.show();
            // detail.show();
            //testAuto.show();
            //equipment.show();
            //testExpress.show();
        }
    }

