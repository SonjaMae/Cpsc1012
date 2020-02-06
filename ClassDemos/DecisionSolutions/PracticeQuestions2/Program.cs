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
                    //A $9.95 per month for up to 10 hours; additional hours are billed at $2.00 per hour
                    //B $13.95 per month for up to 20 hours; additional hours are billed at $1.00 per hour
                    //C $19.95 per month for unlimited hours;

            //The program should: 
            //prompt for the letter of the service package(A, B, or C) 
            //and the number of hours they have used if either option A or B has been selected.

            string internetPackage;
            string hoursUsed;
            double hoursUsedDouble;
            double billAmount = 0;

            Console.Write("Select whether you have Internet Package A, B, or C:\t");
            internetPackage = Console.ReadLine();

            switch (internetPackage)
            {
                case "a":
                case "A":
                    {
                        //$9.95 per month up to 10 hours;
                        //additional $2.00 per hour;

                        Console.Write("Now please enter the number of hours of internet you've used this month:\t");
                        hoursUsed = Console.ReadLine();
                        hoursUsedDouble = double.Parse(hoursUsed);
                        if (hoursUsedDouble <= 10)
                        {
                            billAmount = 9.95;
                        }
                        else
                        {
                            billAmount = 9.95 + ((hoursUsedDouble - 10) * 2);
                        }
                        
                        break;
                    }
                case "b":
                case "B":
                    {
                        //$13.95 per month for up to 20 hours; 
                        //additional $1.00 per hour;

                        Console.Write("Now please enter the number of hours of internet you've used this month:\t");
                        hoursUsed = Console.ReadLine();
                        hoursUsedDouble = double.Parse(hoursUsed);
                        if (hoursUsedDouble <= 20)
                        {
                            billAmount = 13.95;
                        }
                        else
                        {
                            billAmount = 13.95 + (hoursUsedDouble - 20);
                        }
                        
                        break;
                    }
                case "c":
                case "C":
                    {
                        //$19.95 per month for unlimited hours;

                        billAmount = 19.95;
                        
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

            /*Write a program that can allow the user to perform some simple unit conversions.
             * 
             * The program should:
                 * display a menu of available options to the user, 
                 * prompt for the desired option, 
                 * and then prompt for the value. 
                 * The conversion should be performed 
                 * and the new value should be displayed.  
             * 
             * Use the following table for conversions: 
                 * POUNDS TO KILOGRAMS 
                 *      kg = lb / 2.2046 
                 * FLUID OUNCES (U.S.) TO LITERS 
                 *      1 liter = 33.8140226 ounces 
                 * INCHES TO CENTIMETERS 
                 *      cm = in / 0.39370 
                 * FAHRENHEIT TO CELSIUS 
                 *      C = (F - 32) / 1.800 
             * 
             * As an option, also allow for conversions in the opposite direction (e.g. kilograms to pounds) */

            string conversionType;
            string initialAmount;
            int initialAmountInt;
            double convertedAmount;

            Console.WriteLine("Enter the letter code indicating which type of conversion you'd like to execute:\n");
            Console.WriteLine("A: Pounds to kilograms");
            Console.WriteLine("B: Kilograms to pounds");
            Console.WriteLine("C: Fluid ounces to liters");
            Console.WriteLine("D: Liters to fluid ounces");
            Console.WriteLine("E: Inches to centimetres");
            Console.WriteLine("F: Centimetres to inches");
            Console.WriteLine("G: Fahrenheit to celsius");
            Console.WriteLine("H: Celcius to fahrenheit");
            conversionType = Console.ReadLine();

            switch (conversionType.ToUpper())
            {
                case "A":
                    {
                        //POUNDS TO KILOGRAMS
                        //kg = lb / 2.2046

                        Console.Write("Now enter the amount of pounds you'd like to convert to kilograms:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = initialAmountInt / 2.2046;
                        Console.WriteLine($"{initialAmount} pounds converts to {convertedAmount} kilograms.");

                        break;
                    }
                case "B":
                    {
                        //POUNDS TO KILOGRAMS
                        //kg = lb / 2.2046

                        Console.Write("Now enter the amount of kilograms you'd like to convert to pounds:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = initialAmountInt * 2.2046;
                        Console.WriteLine($"{initialAmount} kilograms converts to {convertedAmount} pounds.");

                        break;
                    }
                case "C":
                    {
                        //FLUID OUNCES(U.S.) TO LITERS
                        //1 liter = 33.8140226 ounces

                        Console.Write("Now enter the amount of fluid ounces you'd like to convert to liters:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = initialAmountInt / 33.8140226;
                        Console.WriteLine($"{initialAmount} fluid ounces converts to {convertedAmount} liters.");

                        break;
                    }
                case "D":
                    {
                        //LITERS TO FLUID OUNCES(U.S.)
                        //1 liter = 33.8140226 ounces

                        Console.Write("Now enter the amount of liters you'd like to convert to fluid ounces:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = initialAmountInt * 33.8140226;
                        Console.WriteLine($"{initialAmount} liters converts to {convertedAmount} fluid ounces.");

                        break;
                    }
                case "E":
                    {
                        //INCHES TO CENTIMETERS 
                        //cm = in / 0.39370

                        Console.Write("Now enter the amount of inches you'd like to convert to centimetres:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = initialAmountInt / 0.39370;
                        Console.WriteLine($"{initialAmount} inches converts to {convertedAmount} centimetres.");

                        break;
                    }
                case "F":
                    {
                        //CENTIMETERS TO INCHES
                        //cm = in / 0.39370

                        Console.Write("Now enter the amount of centimetres you'd like to convert to inches:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = initialAmountInt * 0.39370;
                        Console.WriteLine($"{initialAmount} centimetres converts to {convertedAmount} inches.");

                        break;
                    }
                case "G":
                    {
                        //FAHRENHEIT TO CELSIUS
                        //C = (F - 32) / 1.800

                        Console.Write("Now enter the Fahrenheit amount you'd like to convert to Celsius:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = (initialAmountInt - 32) / 1.800;
                        Console.WriteLine($"{initialAmount} Fahrenheit converts to {convertedAmount} Celsius.");

                        break;
                    }
                case "H":
                    {
                        //CELSIUS TO FAHRENHEIT
                        //C = (F - 32) / 1.800

                        Console.Write("Now enter the Celsius amount you'd like to convert to Fahrenheit:\t");
                        initialAmount = Console.ReadLine();
                        initialAmountInt = int.Parse(initialAmount);
                        convertedAmount = (initialAmountInt + 32) * 1.800;
                        Console.WriteLine($"{initialAmount} Celsius converts to {convertedAmount} Fahrenheit.");

                        break;
                    }
                default:
                    {
                        Console.Write("Invalid input value.");
                            
                        break;
                    }
            }
        }
    }
}
