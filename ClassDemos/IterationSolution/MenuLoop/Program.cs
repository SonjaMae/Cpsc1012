using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic menu setup

            //loop: post-loop

            //loop contents:
            //prompt for menu option
            //switch with a case for each option, default is bad menu option
            //within the case, we will simply output a message
            //decide how to terminate your loop

            string menuOption = "";

            do
            {
                //prompts
                Console.WriteLine("Select an option from the following menu:\t");
                Console.WriteLine("A) Play Even or Odd");
                Console.WriteLine("B) Play Heads or Tails");
                Console.WriteLine("C) Play Sum of Squares");
                Console.WriteLine("X) Exit\n");
                Console.Write("Enter your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {
                    case "A":
                        {
                            //place any logic to do in case A
                            Console.WriteLine("You chose to play Even or Odd.\n");
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
                                    if (int.TryParse(inputString, out number))
                                    {
                                        //set flag to an appropriate value to work with your logic
                                        validFlag = true;
                                    }
                                } while (validFlag == false);
                                //eow2

                                if (number > 0)
                                {
                                    if (number % 2 == 0)
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
                                    if (number == 0)
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
                            break;
                        }
                    case "B":
                        {
                            //place the heads or tails game in this case
                            //validate that an h or a t was entered, if not repeat query for input

                            Console.WriteLine("You chose to play Heads or Tails.\n");
                            int heads = 0;
                            int tails = 0;

                            int loopCounter = 1;
                            string inputValue;

                            while (loopCounter <= 7)
                            {

                                Console.Write("Enter heads or tails:\t");
                                inputValue = Console.ReadLine();

                                if (inputValue.ToLower().Equals("heads"))
                                {
                                    heads++;  //running total
                                }
                                else if (inputValue.ToLower().Equals("tails"))
                                {
                                    tails++;    //running total
                                }//eof
                                else
                                {
                                    Console.WriteLine("Invalid input value.\n");
                                }

                                loopCounter++;

                                Console.WriteLine($"Your number of heads is {heads}");
                                Console.WriteLine($"Your number of tails is {tails}\n\n");
                            }
                            break;
                        }
                    case "C":
                        {
                            //the sum of squares
                            //enter positive integer number (validate)
                            //loop n times where n is the integer number (1 to n)
                            //within the loop your calculation is total = loopnumber * loopnumber
                            //after the loop, display your integer number and its sum of squares
                            //example: 
                                    //entered 4
                                    //do the loop 4 times
                                    //1st time is 1 * 1
                                    //2nd time is 2 * 2
                                    //3rd time is 3 * 3
                                    //4th time is 4 * 4
                                    //final total = 30 (16+9+4+1=30)
                            Console.WriteLine("You chose to play Sum of Squares.\n");

                            string inputInteger;
                            int loopNumber = 1;
                            int totalValue = 0;
                            int finalTotal = 0;

                            Console.Write("Enter a positive integer value:\t");
                            inputInteger = Console.ReadLine();
                            int inputIntegerInt = int.Parse(inputInteger);

                            do
                            {
                                totalValue = loopNumber * loopNumber;
                                
                                loopNumber++;

                            } while (loopNumber <= inputIntegerInt);

                            finalTotal = totalValue + totalValue + totalValue + totalValue;

                            Console.WriteLine($"\nThe total square sum of your input value, {inputInteger}, is {finalTotal}.\n\n");

                            break;
                        }
                    case "X":
                        {
                            //place any logic to do in case X here
                            Console.WriteLine("Thank you. Come again.\n\n");
                            break;
                        }
                    default:
                        {
                            //this case acts as a validation for the proper value of a menuOption
                            Console.WriteLine($"Your menu option choice of {menuOption} is incorrect. Try again.\n\n");
                            break;
                        }
                }
                
            } while (menuOption.ToUpper() != "X");
            Console.ReadKey();
        }
    }
}
