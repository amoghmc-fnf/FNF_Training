using System;

class RDCalculator {
    public int monthlyDeposit { get; set; }  
    public int timeInMonths { get; set; }
    public double interestRate { get; set; }

    public double calculateRD() {
        int P = monthlyDeposit;
        double r = interestRate;
        int n = timeInMonths;
        int nPlusOne = n + 1;
        return P * n * (1 + ((nPlusOne * r) / 2400));
    }
}