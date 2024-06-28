using System;
namespace SampleConApp {
    
    class Machine {
        public String SerialNo { get; set; }
        public String Make { get; set; }
        public int Price { get; set; }
        public String Model { get; set; }

        public override String ToString() {
            // return "Serial No: " + SerialNo + "\nMake: " + Make + "\nModel: " + Model + "\nPrice: " + Price;
            return string.Format("Serial No: {0}\nMake: {1}\nModel: {2}\nPrice: {3}", SerialNo, Make, Model, Price);
        }
    }

    class Ex04ClassesAndObjects {
        static void GetMachineDetails() {
            Console.WriteLine("Enter Serial No");
            String serialNo = Console.ReadLine();

            Console.WriteLine("Enter Make");
            String make = Console.ReadLine();

            Console.WriteLine("Enter Model");
            String model = Console.ReadLine();

            Console.WriteLine("Enter Price");
            int price = int.Parse(Console.ReadLine());

            Machine myMachine = new Machine { 
                SerialNo = serialNo, 
                Make = make, 
                Price = price, 
                Model = model
            };
            // myMachine.SerialNo = serialNo;
            // myMachine.Make = make;
            // myMachine.Price = price;
            // myMachine.Model = model;

            Console.WriteLine(myMachine);
        }

        static void GetMachineDetailsWithMyConsole() {
            Console.WriteLine("Calling with MyConsole");
            String serialNo = MyConsole.GetString("Enter Serial No");
            String model = MyConsole.GetString("Enter Model");
            String make = MyConsole.GetString("Enter Make");
            int price = MyConsole.GetInteger("Enter Price");

            Machine myMachine = new Machine { 
                SerialNo = serialNo, 
                Make = make, 
                Price = price, 
                Model = model
            };
            // myMachine.SerialNo = serialNo;
            // myMachine.Make = make;
            // myMachine.Price = price;
            // myMachine.Model = model;

            Console.WriteLine(myMachine);
        }

        static void Main() {
            GetMachineDetailsWithMyConsole();
        }


    }
}