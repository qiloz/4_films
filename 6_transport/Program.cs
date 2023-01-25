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

    class Details : Train {
        string transportID = "Поезд";
        int code;
        int measure;
        string manufacture;
        string dateOfConstruct;
        public string engine = new string("");

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

        public Details(int code, int measure, string manufacture, string dateOfConstruct, int speed, string engine) : base (code, measure, manufacture, dateOfConstruct, speed) {
           this.code = code;
           this.measure = measure;
           this.manufacture = manufacture;
           this.dateOfConstruct = dateOfConstruct;
           this.speed = speed;
           this.engine = engine;
        }

        public override void typeOfTransport() {
            Console.WriteLine("Тип: {0}", transportID);
        }
        
        public override void show(){
            Console.WriteLine("Двигатель: {0}", engine); 
        }
    }

    class Program {
        public static void Main(String[] args){
            Train testTrain = new Train(1, 2, "helloworld", "4", 5);
            Details detail = new Details(1, 2, "helloworld", "4", 5, "test");
            //Auto testAuto = new Auto(2, 10, "helloworld", "4", 5, 6);
            //Express testExpress = new Express(3, 122, "helloworld", "4", 5, 6);
            testTrain.show();
            detail.show();
            //testAuto.show();
            //testExpress.show();
        }
    }
}
