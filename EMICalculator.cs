using System;

class EMICalculator {
    private const int MinCarLoanTenure = 36;
    private const int MinHouseLoanTenure = 120;
    public double principal { get; set; }  
    public double monthlyInterestRate { get; set; }
    public int loanTenure { get; set; }

    private double calculateEMI() {
        double P = principal;
        double R = (monthlyInterestRate / 12) / 100;
        int N = loanTenure;
        double onePlusR = 1 + R;
        double onePlusRToN = Math.Pow(onePlusR, N);
        return P * R * (onePlusRToN / (onePlusRToN - 1));
    }

    public double calculateCarEMI() {
        if (MinCarLoanTenure > loanTenure) {
            throw new Exception("Car loan tenure cannot be less than 3 years!");
        }
        else {
            return calculateEMI();
        }
    }

    public double calculateHouseEMI() {
        if (MinHouseLoanTenure > loanTenure) {
            throw new Exception("House loan tenure cannot be less than 10 years!");
        }
        else {
            return calculateEMI();
        }
    }
}