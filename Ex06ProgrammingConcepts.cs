using System;

namespace SampleConApp {
    class Ex06ProgrammingConcepts {
        static double Processing(double first, double second, string operation) {
            Arithmetic arth = new Arithmetic {
                firstValue = first,
                secondValue = second,
                operation = operation
            };
            return arth.PerformOperation();
        }
        static void Main() {
            Console.WriteLine("Welcome to Windows Calculator!");
            string stopSignal = "";
            do {
                double first = MyConsole.GetDouble("Enter first number");
                double second = MyConsole.GetDouble("Enter second number");
                string operation = MyConsole.GetString("Enter mode of operation: +, -, /, x");

                try {
                    double result = Processing(first, second, operation);
                    Console.WriteLine("The result is {0}", result);
                    stopSignal = MyConsole.GetString("Do you want to continue? Press Y for Yes");
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                
            }
            while (stopSignal.ToUpper() == "Y");
        }
    }

    class Arithmetic {
        public double firstValue { get; set; }
        public double secondValue { get; set; }
        public string operation { get; set; }
        public double PerformOperation() {
            switch(operation) {
                case "+":
                    return firstValue + secondValue;
                case "-":
                    return firstValue - secondValue;
                case "x":
                    return firstValue * secondValue;
                case "/":
                    return firstValue / secondValue;
                default:
                    throw new Exception("Invalid Operation!");
            }
        }
    }
}