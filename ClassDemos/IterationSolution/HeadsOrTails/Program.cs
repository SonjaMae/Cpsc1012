using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample of pretest loops:
            //while loop
            //for loop

            //code a while loop that breaks the components of a for loop into visible individual items
            //counter: this variable will count the number of times through the loop
            //while condition: counter is less than my stop value
            //(stop value is either an upper or lower limit

            //go through the loop 7 times
            //count the number of even numbers, number of odd numbers
            //after the loop print out the even and odd number running totals

            int heads = 0;
            int tails = 0;

            int loopCounter = 1;
            string inputValue;
            string repeatValue;

            while (loopCounter <= 10)
            {

                Console.Write("Enter heads or tails:\t");
                inputValue = Console.ReadLine();

                if (inputValue.ToLower().Equals("heads"))
                {
                    heads++;  //running total
                }
                else
                {
                    tails++;    //running total
                }//eof


                Console.WriteLine($"Your number of heads is {heads}");
                Console.WriteLine($"Your number of tails is {tails}\n\n");

                Console.WriteLine("Would you like to play again? Enter y for yes or n for no.\t");
                repeatValue = Console.ReadLine();
                if (repeatValue.ToLower().Equals("yes"))
                {

                }
                else
                {

                }

            }
        }
    }
}

