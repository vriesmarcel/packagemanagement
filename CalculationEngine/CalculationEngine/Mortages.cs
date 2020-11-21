using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationEngine
{
    public class Mortages : IMortgageCalculations
    {
        
        public double MortgageMaximum(double yearIncome, double homeValue)
        {
        
            var maximum = 4.2 * yearIncome;
            if (maximum > homeValue)
            {
                maximum = homeValue * .8;
             }
            return maximum;
        }

        public double MortgageRepaymentSummary(double homeValue, double loanAmount, double interestRate, int termInYears)
        {
            // Calculations are totaly random and not representing any real world calculation
            // it is just some code that calculates some value.
            double total = 0;
            double depreciation = loanAmount / termInYears;
            double interestPerYear = loanAmount * interestRate;

            for (int year = 0; year<termInYears; year++)
            {
                total += depreciation + interestPerYear;
                total += total * interestRate;
            }

            return total;
        }
    }
}
