using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //query user for a number
            //validate that a number was entered (integer)
            //if a number was entered, check for even/odd
            //continue unless a 0 was entered, then exit

            //to validate a string to contain a number, use the xxx.TryParse (int.TryParse, double.TryParse, etc.) of the number data type
            //syntax of .TryParse is (string, out variablename)

            //the string holds the value to test
            //if the value is good:
            //the number is automatically placed in your variable
            //the test returns a boolean true
            //if the value is not good:
            //no value is placed in your variable
            //the test returns a boolean false

            int number = -1;
            string inputString = "";

            while (number != 0)
            {
                //do
                //{
                //    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                //    inputString = Console.ReadLine();
                //} while (!int.TryParse(inputString, out number));
                ////eow2


                //condition flag
                //NOTE: it must be reset on EACH pass of the OUTER loop
                //the flag method is easier to understand but it requires more maintenance
                bool validFlag = false;
                do
                {
                    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                    inputString = Console.ReadLine();
                    //you need a test to appropriately set your loop exit test
                    if(int.TryParse(inputString,out number))
                    {
                        //set flag to an appropriate value to work with your logic
                        validFlag = true;
                    }
                } while (validFlag == false);
                //eow2

                if (number > 0)
                {
                    if(number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is an even value.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is an odd value.\n\n");
                    }
                    //eoi2
                }
                else
                {
                    if(number == 0)
                    {
                        Console.WriteLine("Thank you. Come again.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is invalid. Try again.\n\n");
                    }
                    //eoi3
                }
                //eoi1
            }
            //eow1
        }
    }
}
