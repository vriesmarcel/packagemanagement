namespace CalculationEngine
{
    public interface IMortgageCalculations
    {
        double MortgageRepaymentSummary(double homeValue, double loanAmount, double interestRate, int termInYears);
        double MortgageMaximum(double yearIncome, double homeValue);
    }
}