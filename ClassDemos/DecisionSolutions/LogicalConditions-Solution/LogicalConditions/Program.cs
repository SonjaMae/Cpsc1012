using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical conditions are two or more conditions separated by a logic operation
            //relative operators:
            // > >= < <= == !=
            //operand operator operand (high > low)
            //logical operators:
            // || (or) && (and) ! (not)

            int Age = 6;
            if (Age < 4)
            {
                Console.WriteLine("Too young.");
            }
            else if (Age > 14)
            {
                Console.WriteLine("Too old.");
            }
            else
            {
                Console.WriteLine("Welcome to the league.");
            }

            //but... what about using logical operators?
            //note the operand is repeated for each relative test condition
            //(Age < 4 || > 14) is incorrect syntax because you must repeat each operand
            //(Age < 4 && Age > 14) is incorrect syntax because you can't be both under 4 and over 14 at the same time

            //Truth table:
            //conditions   or    and
            // T  T         T     T
            // T  F         T     F
            // F  T         T     F
            // F  F         F     F

            //summary:
            // && is only true if both relative conditions are true
            // || is only false if both relative conditions are false

            if (Age < 4 || Age > 14)
            {
                //one does not know if the age is less than or greater than
                Console.WriteLine("Sorry, you are not in the age bracket for this league.");
            }
            else
            {
                Console.WriteLine("Welcome to the league.");
            }
        }
    }
}
