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
             * Input: The amount of principal, the annual interest rate as a percentage of 100 (2% should be entered as 2, not 0.2), and the number of years for the loan.
             * Processes: Read input values, convert input values to variables (camcelCase for local, ALL_CAPS for constant), use the provided formula for amortization calculation, display result to user. 
             * Output:  Recap the input values entered by the user then display the amount that the monthly payment will be on the specified loan.
             * Author: Sonja Mae Holowaychuk
             * Last modified: January 23, 2020
             */

            //The formula is A = P * (r(1+r)^n) / (1+r)^n - 1))
            //A = payment per month
            //P = principal
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
            double monthlyInterestRate = theInterestRate / 12.0 / 100;

            Console.WriteLine("Finally, please enter the number of years for the loan:\t");
            string inputYears = Console.ReadLine();
            double theYears = double.Parse(inputYears);
            double numberOfMonths = (double)theYears * 12;

            //The formula is A = P * (r(1+r)^n) / (1+r)^n - 1))
            //A = payment per month          (outputAmortization)
            //P = principal                  (thePrincipal)
            //r = interest rate per month    (monthlyInterestRate)
            //n = total number of payments   (numberOfMonths)
            //Apply the formula:
            double outputAmortization =
                thePrincipal * ((monthlyInterestRate *
                Math.Pow((1 + monthlyInterestRate), numberOfMonths)) / 
                (Math.Pow(1 + monthlyInterestRate, numberOfMonths) - 1));

            //Display the results:
            Console.WriteLine($"This loan (with a ${thePrincipal} principal amount, " +
                $"a {theInterestRate}% annual interest rate, " +
                $"and a {theYears} year duration) " +
                $"will have a monthly payment amount of ${outputAmortization:0.00} " +
                $"over a period of {numberOfMonths} monthly payments.");
            Console.ReadKey();
        }
    }
}
