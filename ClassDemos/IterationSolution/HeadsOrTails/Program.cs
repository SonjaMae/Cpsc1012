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
            //heads or tails game
            //validate that an h or a t was entered, if not repeat query for input

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
        }
    }
}

