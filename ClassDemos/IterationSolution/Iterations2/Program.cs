﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, hightest = -99;
            int number;          //declare and default to 0
            const int Two = 2;   //this is a non changable variable      
            string inputValue;

            //the loop structure demonstrated in this sample is a Pre-Test
            //Pre-Test is also known as Do While
            //Pre-Test checks to see if the condition is true BEFORE
            //    executing the code
            //after the code has executed, the Pre-Test condition is still true
            //if the condition is still true the loop code is re-executed
            //if the condition is false the loop terminates and execution
            //    continues with the remainder of the program

            Console.Write("Do you wish to play the Even or Odd game?");
            string answer = Console.ReadLine();

            //the loop construction
            //answer.ToUpper().Equals("Y")
            //answer == "Y" || answer == "y"
            while (answer.Equals("Y") || answer.Equals("y"))
            {
                //within this coding block you are inside your loop
                //this loop will terminate is answer is not Yy

                //TODO: place your loop logic here
                Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % Two) == 0)
                {
                    Console.WriteLine($"Your number {number} is even");
                }
                else
                {
                    Console.WriteLine($"Your number {number} is odd");
                }//eof

                //ask if the user wishes to continue to play the game
                //give the user an opportunity to exit the loop
                Console.Write("\n\nDo you wish to play the Even or Odd game?");
                answer = Console.ReadLine();
            }//eow  end of while

            Console.WriteLine("\n\nYou terminated the loop with you last answer.");
            Console.ReadKey();
        }
    }
}