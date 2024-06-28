using System;
using System.IO;

namespace SampleConApp {
    class Ex05ArrayMacExample {
        static MachineDatabase myMachDB = new MachineDatabase();

        static void Main() {
            string text = File.ReadAllText(@"C:\Users\6147952\Documents\FNF_Training\menu.txt");
            bool processing = false;
            do {
                Console.WriteLine(text);
                string choice = Console.ReadLine();  
                processing = ProcessMenu(choice);
            }
            while (processing);
        }

        static bool ProcessMenu(string choice) {
            switch (choice) {
                case "1":
                    addingMachineFeature();
                    return true;
                case "2":
                    updatingMachineFeature();
                    return true;
                case "3":
                    gettingMachineByIdFeature();
                    return true;
                case "4":
                    gettingAllMachinesFeature();
                    return true;
                default:
                    return false;
            }
        }

        static void addingMachineFeature() {
            Console.WriteLine("Enter details of your machine");

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
            
            myMachDB.RegisterDevice(myMachine);
        }

        static void updatingMachineFeature() {
            Console.WriteLine("Enter serial number of machine to update");
            string serialNo = Console.ReadLine();
            Machine[] machArray = myMachDB.GetAllRegisteredDevices();
            for (int i = 0; i < machArray.Length; i++) {
                if (machArray[i].SerialNo.Equals(serialNo)) {
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

                    myMachDB.UpdateDeviceDetails(serialNo, myMachine);
                    return;
                }
            }
            Console.WriteLine("Machine not found!");
        }

        static void gettingMachineByIdFeature() {
            Console.WriteLine("Enter serial number of machine to find");
            string serialNo = Console.ReadLine();
            Machine[] machArray = myMachDB.GetAllRegisteredDevices();
            for (int i = 0; i < machArray.Length; i++) {
                if (machArray[i].SerialNo.Equals(serialNo)) {
                    Console.WriteLine(machArray[i].ToString());
                    return;
                }
            }
            Console.WriteLine("Machine not found!");
        }

        static void gettingAllMachinesFeature() {
            Console.WriteLine("List of machines are");
            Machine[] machArray = myMachDB.GetAllRegisteredDevices();
            for (int i = 0; i < machArray.Length; i++) {
                Console.WriteLine(machArray[i].ToString());
            }
        }


        
    }
}