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
                            Even_Or_Odd_Game();
                            //^ method's calling statement
                            break; //the break is part of the case, not the method
                        }
                    case "B":
                        {
                            //create a method that holds the actual code for this case
                            //the B case will CALL the method to execute
                            //this action is referred to as the calling statement
                            //calling the method requires your code to use the method name
                            //your program will branch to the requested method
                            //when the method has finished, your program will return to the next executable statement AFTER the method call

                            Heads_Or_Tails_Game();
                            break;
                        }
                    case "C":
                        {

                            //create a shared input method to obtain an integer value
                            int number = GetIntegerInput("Enter a number greater than 0");
                            if (number < 1)
                            {
                                Console.WriteLine($"{number} is not greater than 0. Unable to do Sum of Squares.");
                            }
                            else
                            {
                                int sumofsquares = 0;
                                sumofsquares = SumofSquaresMethod(number);
                                Console.WriteLine($"{sumofsquares} is the sum of squares for {number}");

                            }


                           // Console.WriteLine("You chose to play Sum of Squares.\n");

                           // string inputInteger;
                           // int loopNumber = 1;
                           // int totalValue = 0;
                           // //int finalTotal = 0;

                           // Console.Write("Enter a positive integer value:\t");
                           // inputInteger = Console.ReadLine();
                           // int inputIntegerInt = int.Parse(inputInteger);

                           // do
                           // {
                           //     //totalValue = totalValue + loopNumber * loopNumber;
                           //     //the line below does the same thing except in a shorter fashion
                           //     //the += says "add the right side to the left side"
                           //     totalValue += loopNumber * loopNumber;
                                
                           //     loopNumber++;

                           // } while (loopNumber <= inputIntegerInt);

                           //// finalTotal = totalValue + totalValue + totalValue + totalValue;

                           // Console.WriteLine($"\nThe total square sum of your input value, {inputInteger}, is {totalValue}.\n\n");

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
        }//eom Main

        //the syntax for a method requires:
        //accesstype returndatatype MethodName([list of parameters])
        //^ that first line is called a method header
        //{
        //  your method code
        //} //eom

        //accesstype:
        //public or private
        //protected, internal, have static reference

        //returndatatype:
        //if you're returning nothing, use the keyword void
        //otherwise, return a single value (such as int, double, decimal, DateTime, etc.)

        //MethodName:
        //continuous string of characters which will be used within your program code to reference this coding block
        //it's best to use a meaningful name

        //[list of parameters]
        //this is a set of local variables that will be used to receive values from the calling statement
        //a parameter is a set of datatype and variablename
        //parameters are separated by using ,



        //local variables are NOT automatically passed to any called method

        //method dictates to the calling statement, not the other way around

        //avoid having method name being the same as a variable name

        //methods can be divided into functions or subroutines:
            //functions return a value
            //subroutines don't return anything

        //method stub = a method with only the outline and no content



        //how to pass data to / return data from a method:
        
        //pass by value = when changes made to an original document are unavailable
        
            //to pass data to a method:
        //MethodName (drivervariable, optionalothervariable, etc)
                    //^these variables on the calling statement are called arguments
        //MethodName (int localcopyofdrivervariable, string localcopyofdrivervariable)
                    //^these variables on the method are called parameters
                    //parameters are locally declared, meaning they die at the end of the method

            //to return data to a method:
        //void = nothing returned, so change this method's void to the return's datatype
        //return = i'm sending this variable back to the main (void) method
        //returnedvaluevariable in main method has to match datatype


        static public void Heads_Or_Tails_Game()
        {
            string inputString = "";
            int headcount = 0;
            int tailcount = 0;

            do
            {
                //validation
                do
                {
                    Console.Write("Enter an H (heads) or a T (tails) or Q (quit):\t");
                    inputString = Console.ReadLine();

                } while (!inputString.ToUpper().Equals("H") &&
                    !inputString.ToUpper().Equals("T") &&
                    !inputString.ToUpper().Equals("Q"));

                if (inputString.ToUpper().Equals("H") ||
                    inputString.ToUpper().Equals("T"))
                {
                    //heads or tails
                    if (inputString.ToUpper().Equals("H"))
                    {
                        headcount++;
                        Console.WriteLine($"\n{inputString.ToUpper()} is heads.");
                    }
                    else
                    {
                        tailcount++;
                        Console.WriteLine($"\n{inputString.ToUpper()} is tails.");
                    }
                }
                else
                {
                    if (headcount > tailcount)
                    {
                        Console.WriteLine($"Heads wins over tails: {headcount} to {tailcount}");
                    }
                    else if (headcount < tailcount)
                    {
                        Console.WriteLine($"Tails wins over heads: {tailcount} to {headcount}");
                    }
                    else
                    {
                        Console.WriteLine($"Heads ties tails: {headcount} to {tailcount}");
                    }
                    //quit
                    Console.WriteLine("\n\nThank you. Come again.\n");

                }

            } while (!inputString.ToUpper().Equals("Q"));
        }//eom Heads_Or_Tails_Game

        //(subroutine)
        static public void Even_Or_Odd_Game()
        {
            //place any logic to do in case A
            Console.WriteLine("You chose to play Even or Odd.\n");
            int number = -1;

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
                //bool validFlag = false;
                //do
                //{
                //    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                //    inputString = Console.ReadLine();
                //    //you need a test to appropriately set your loop exit test
                //    if (int.TryParse(inputString, out number))
                //    {
                //        //set flag to an appropriate value to work with your logic
                //        validFlag = true;
                //    }
                //} while (validFlag == false);
                ////eow2
                ///

                number = GetIntegerInput("Enter a positive whole number OR enter 0 to quit.");

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
        }//eom Even_Or_Odd_Game


        //(function)
        static public int SumofSquaresMethod(int seednumber) 
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

            int finalsquare = 0;
            for (int loopcounter = 1; loopcounter <= seednumber; loopcounter++)
            {
                finalsquare += loopcounter * loopcounter;
                //you could also use Math.Square or Math.Pow to calculate the sum of squares
            }
            return finalsquare;
        }

        static public int GetIntegerInput(string promptline)
        {
            bool validFlag = false;
            string inputString = "";
            int number = 0;

            do
            {
                Console.Write(promptline);
                inputString = Console.ReadLine();

                if (int.TryParse(inputString, out number))
                {
                    validFlag = true;
                }
            } while (validFlag == false);

            //if your method indicates that a return datatype is specified, you must have at least 1 return statement in your method code
            return number;
        }

    }
}
