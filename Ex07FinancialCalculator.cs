using System;

namespace SampleConApp {
    class Ex07FinancialCalculator {
        static void Main() {
            Console.WriteLine("Welcome to Financial Calculator!");
            string stopSignal = "";
            do {
                try {
                    double result = ProcessMenu();
                    Console.WriteLine("The result is {0}", result);
                    stopSignal = MyConsole.GetString("Do you want to continue? Press Y for Yes");
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            while (stopSignal.ToUpper() == "Y");
        }

        static double ProcessMenu() {
            string operation = MyConsole.GetString("Enter E for EMI and R for RD");
            switch(operation) {
                case "E":
                    double principal = MyConsole.GetDouble("Enter principal");
                    int loanTenure = MyConsole.GetInteger("Enter loan tenure in months");
                    double interestRate = MyConsole.GetDouble("Enter interest rate");
                    string emiOperation = MyConsole.GetString("Enter C for car loan and H for home loan");
                    return ProcessEMI(principal, loanTenure, interestRate, emiOperation);
                case "R":
                    int monthlyDeposit = MyConsole.GetInteger("Enter monthly deposit");
                    int time = MyConsole.GetInteger("Enter time in months");
                    double interestRateRD = MyConsole.GetDouble("Enter interest rate");
                    return ProcessRD(monthlyDeposit, time, interestRateRD);
                default:
                    throw new Exception("Invalid operation!");
            }
        }

        static double ProcessEMI(double principal, int loanTenure, double interestRate, string operation) {
            EMICalculator emiCalc = new EMICalculator {
                principal = principal,
                loanTenure = loanTenure,
                monthlyInterestRate = interestRate
            };

            switch(operation) {
                case "C":
                    return emiCalc.calculateCarEMI();
                case "H":
                    return emiCalc.calculateHouseEMI();
                default:
                    throw new Exception("Invalid operation!");
            }
        }

        static double ProcessRD(int monthlyDeposit, int time, double interestRate) {
            RDCalculator rdCalc = new RDCalculator {
                monthlyDeposit = monthlyDeposit,
                timeInMonths = time,
                interestRate = interestRate
            };
            return rdCalc.calculateRD();
        }
    }

    
}