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
            Console.WriteLine("Код: {0} | Длина: {1} | Производитель: {2} | Дата производства: {3} | Скорость: {4} | Потребление: {5}", code, measure, manufacture, dateOfConstruct, speed, consumption); 
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
            Console.WriteLine("Двигатель: {0}", engine); 
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
            Console.WriteLine("Комплектация: {0}", equipment); 

        }
    }


    class Program {
        public static void Main(String[] args){
            string[] lines = System.IO.File.ReadAllLines(@"./input.txt");
            int number = lines.GetLength(0);
            Console.WriteLine("Lines of txt: {0}", number);

            int countTrains = 0;
            int countCars = 0;
            int countExpress = 0;

            string parserMode = "";
            // Train[] trains = new Train()[number]; 
            
            // count lines
            foreach(string line in lines) {
                Console.WriteLine(line + "\n");
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
                        Console.WriteLine("cars");
                        break;
                    case "express":
                        countExpress++; 
                        Console.WriteLine("express");
                        break;
                }
            }

            
            Train trainsDefault = new Train();
            TrainDetails detailsDefault = new TrainDetails();
            Train[] trains = new Train[countTrains];
            TrainDetails[] details = new TrainDetails[countTrains];

            Auto autosDefauls = new Auto();
            Auto equipmentDefault = new AutoEquipment();
            Auto[] autos = new Auto[countCars];
            AutoEquipment[] equipment = new AutoEquipment[countCars];

            Express expressDefault = new Express();
            Express[] express = new Express[countExpress];
            

            trains[0] = trainsDefault;
            trains[0].show();

            // Console.WriteLine("trains = {0}; cars = {1}; express = {2}", countTrains, countCars, countExpress);
            // working with classes 
            foreach(string line in lines) {
                //Console.WriteLine(line + "\n");
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

