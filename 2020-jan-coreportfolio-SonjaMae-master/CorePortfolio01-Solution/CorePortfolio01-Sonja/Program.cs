using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio01_Sonja
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Purpose: Calculate and display the amount that the monthly payment will be on a loan.
             * Input: The amount of principal,
             *          the annual interest rate as a percentage of 100 (2% should be entered as 2, not 0.2),
             *          and the number of years for the loan.
             * Processes: Read input values,
             *              convert input values to variables (camcelCase for local, ALL_CAPS for constant),
             *              use the provided formula for amortization calculation,
             *              display result to user. 
             * Output: The amount that the monthly payment will be on the specified loan, including a recap of the values entered by the user.
             * Author: Sonja Mae Holowaychuk
             * Last modified: January 20, 2020
             */

            //The formula is A = P * ((r(1+r)^n) / (1+r)^n - 1))
            //A = payment per month
            //P = principle
            //r = interest rate per month
            //n = total number of payments

            //Math.Pow(1+r, ^n)

            //Collect all three input values and convert them each to variables:
            Console.WriteLine("Please enter the amount of principal on your loan:\t");
            string inputPrincipal = Console.ReadLine();
            double thePrincipal = double.Parse(inputPrincipal);

            Console.WriteLine("Now please enter the annual interest rate as a percentage of 100 (2% should be entered as 2, not 0.2):\t");
            string inputInterestRate = Console.ReadLine();
            double theInterestRate = double.Parse(inputInterestRate);

            Console.WriteLine("Finally, please enter the number of years for the loan:\t");
            string inputYears = Console.ReadLine();
            double theYears = double.Parse(inputYears);
            double theMonths = theYears / 12;
            double interestRatePerMonth = theMonths * 100;

            //Apply the formula:
            double outputAmortization = thePrincipal * (theInterestRate ^ (Math.Pow(1 + theInterestRate, theMonths)
                                                        / (1 + theInterestRate)) ^ n - 1);

            //Display the results
            Console.WriteLine($"The ")
        }
    }
}
