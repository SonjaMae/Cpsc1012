using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            //Write a program for an Internet service provider so they can calculate how much to bill their customers.
            //The provider offers customers 3 packages: 
                //PACKAGE COST CALCULATION 
                    //A $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour
                    //B $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour
                    //C $19.95 per month for unlimited hours;
            //The program should prompt for the letter of the service package(A, B, or C) and the number of hours they have used if either option A or B has been selected.

            string internetPackage;
            string hoursUsed;
            string billAmount;

            Console.Write("Select whether you have Internet Package A, B, or C:\t");
            internetPackage = Console.ReadLine();

            switch (internetPackage)
            {
                case "a":
                case "A":
                    {
                        Console.Write("Now please enter the number of hours of internet you've used this month:\t");
                        hoursUsed = Console.ReadLine();

                        billAmount = (9.95 + ((hoursUsed >= 10) * 2));
                        //$9.95 per month up to 10 hours;
                        //additional $2.00 per hour;
                        break;
                    }
                case "b":
                case "B":
                    {
                        Console.Write("Now please enter the number of hours of internet you've used this month:\t");
                        hoursUsed = Console.ReadLine();

                        billAmount = "13.95 + ((> 20) * 1)";
                        //$13.95 per month for up to 20 hours; 
                        //additional $1.00 per hour;
                        break;
                    }
                case "c":
                case "C":
                    {
                        billAmount = "19.95";
                        //$19.95 per month for unlimited hours;
                        break;
                    }
                default:
                    {
                        internetPackage = "Invalid. Please enter either A, B, or C.";
                        break;
                    }
            }
            Console.WriteLine($"Based on your Internet Package type (Package {internetPackage}), your monthly bill will be {billAmount:c}.");
            Console.ReadKey();


            //Question 2

            /*Write a program that can allow the user to perform some simple unit conversions.  The program should display a menu of available options to the user, prompt for the desired option, and then prompt for the value.  The conversion should be performed and the new value should be displayed.  Use the following table for conversions: 
             * 
             * CONVERSION FORMULA POUNDS TO KILOGRAMS kg = lb / 2.2046 FLUID OUNCES (U.S.) TO LITERS 1 liter = 33.8140226 ounces INCHES TO CENTIMETERS cm = in / 0.39370 FAHRENHEIT TO CELSIUS C = (F - 32) / 1.800 
             * As an option, also allow for conversions in the opposite direction (e.g. kilograms to pounds) */

        }
    }
}
