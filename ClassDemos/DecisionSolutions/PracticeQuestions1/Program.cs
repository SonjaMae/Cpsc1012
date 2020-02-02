using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            /*prompt for a number
             * display positive if > 0
             * display negative if < 0
             * display zero if = 0*/
            int theNumber;
            string inputValue;
            Console.WriteLine("Please enter a number:\t");
            inputValue = Console.ReadLine();
            theNumber = int.Parse(inputValue);

            if (theNumber > 0)
            {
                Console.WriteLine($"The number {theNumber} is positive");
            }
            else if (theNumber < 0)
            {
                Console.WriteLine($"The number {theNumber} is negative");
            }
            else if (theNumber == 0)
            {
                Console.WriteLine($"The number {theNumber} is zero");
            }
            Console.ReadKey();


            //Question 2
            /*prompt for the user's age
             *display admission amount for their age group*/
            int userAge;
            Console.WriteLine("Please enter your age:\t");
            inputValue = Console.ReadLine();
            userAge = int.Parse(inputValue);

            if (userAge < 6)
            {
                Console.WriteLine("Your admission is free!");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Your admission is $9.80.");
            }
            else if (userAge < 55)
            {
                Console.WriteLine("Your admission is $11.35.");
            }
            else if (userAge > 54)
            {
                Console.WriteLine("Your admission is $10.00.");
            }
            Console.ReadKey();


            //Question 3
            /*prompt for a student's name and their mark
             * display the student's name and their letter grade based on their mark
             * a = 100-90
             * b = 89-80
             * c = 79-70
             * d = 69-50
             * f = 49-0*/
            string numberGrade;
            int percentageRange;
            string studentName;

            Console.WriteLine("Please enter the student's name:\t");
            studentName = Console.ReadLine();

            Console.WriteLine("Now please enter their grade as a number:\t");
            numberGrade = Console.ReadLine();
            percentageRange = int.Parse(numberGrade);

            if (percentageRange >= 90 && percentageRange <= 100)
            {
                Console.WriteLine($"The student {studentName}'s numerical grade of {numberGrade}% would be an A letter grade.");
            }
            else if (percentageRange >= 80 && percentageRange <= 89)
            {
                Console.WriteLine($"The student {studentName}'s numerical grade of {numberGrade}% would be a B letter grade.");
            }
            else if (percentageRange >= 70 && percentageRange <= 79)
            {
                Console.WriteLine($"The student {studentName}'s numerical grade of {numberGrade}% would be a C letter grade.");
            }
            else if (percentageRange >= 50 && percentageRange <= 69)
            {
                Console.WriteLine($"The student {studentName}'s numerical grade of {numberGrade}% would be a D letter grade.");
            }
            else if (percentageRange >= 0 && percentageRange <= 49)
            {
                Console.WriteLine($"The student {studentName}'s numerical grade of {numberGrade}% would be an F letter grade.");
            }
            else
            {
                Console.WriteLine($"The entered numerical grade {numberGrade} is invalid.");
            }
            Console.ReadKey();


            //Question 4
            /*compute the income tax due on a taxable income entered by the user
             * prompt for the user's taxable income
             * display the income tax due on it*/
             //taxable income       tax due
             //up to $50 000        $0 + 5% of amount over $0
             //up to $100 000       $$2 500 + 7% of amount over $50 000
             //$100 000 and over    $6 000 + 9% of amount over $100 000
            string taxableIncome;
            double taxableIncomeDouble;
            double incomeTax;
            string msg = "";

            Console.WriteLine("Please enter your taxable income:\t");
            taxableIncome = Console.ReadLine();
            taxableIncomeDouble = double.Parse(taxableIncome);


            if (taxableIncomeDouble <= 50000)
            {
                incomeTax = taxableIncomeDouble * 0.05;
                msg = $"The income tax owed is {incomeTax}.";
            }
            else if (taxableIncomeDouble > 50000 && taxableIncomeDouble <= 100000)
            {
                incomeTax = ((taxableIncomeDouble - 50000) * 0.07) + 2500;
                msg = $"The income tax owed is {incomeTax}.";
            }
            else if (taxableIncomeDouble > 100000)
            {
                incomeTax = ((taxableIncomeDouble - 100000) * 0.09) + 6000;
                msg = $"The income tax owed is {incomeTax}.";
            }
            Console.WriteLine(msg);
            Console.ReadKey();

            //double Earnings = 25000; CamelCase for doubles
            //decimal taxAmount = 0.00m; pascalCase for decimals
            //const decimal FIVEPERCENT = 0.05m; UPPERCASE for constants

            //go down an extra line with \n
            //go down two extra lines with \n\n
            //insert a tab with \t

            //complier doesn't like mixing of types of variables in the same equation. solutions:     a) make Earnings a decimal
            //                                                                                        b) make everything a double
            //                                                                                        c) cast Earnings temporarily to a decimal:
            //                                                                           taxAmount = (decimal)Earnings * FIVEPERCENT;
            //                                                                           taxAmount = 2500.00m + (decimal)(Earnings - 50000) * SEVENPERCENT;

            //dollar amounts can be done with:      a) formatting using {:0.00} (without $) or $0.00 (with $)
            //                                      b) formatting using {:c} (stands fopr currency) will automatically apply $#,###,### formatting
            //Console.WriteLine($"Earnings: {Earnings:$#,###,##0.00}\t  Taxes: {taxAmount:c}");
            //though the above code will work, apply only one consistent style of formatting in your code
            //you can use the # sign as a digit placeholder. # is used as "if a digit space is needed then use this #'s space, otherwise the # will not show"

            //the syntax for column formatting is {variable,columnsize:formatstring}
            //      variable is the data to output
            //      columnsize is the number of character spacing to be used for the column
            //              positive columnsize is right-aligned
            //              negative columnsize is left-aligned
            //      formatstring is your string format
                                        //put out the tax table as a column formatted table:
                                        //using a \t character will give columns depending on the length of your outputstring (inconsistent)
                                        //
                                        //Console.WriteLine("{0,15} {1,13}","Earnings:","Taxes:");
                                        //Console.WriteLine($"{Earnings,15:c} {taxAmount,13:c}");
                                        //Console.WriteLine($"\n");
        }
    }
}
