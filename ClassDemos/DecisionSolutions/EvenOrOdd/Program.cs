using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {            
            int number;                     
            const int Two = 2;     //this is a non-changeable variable                
            string inputValue;

            Console.Write("Enter first number:\t");
            inputValue = Console.ReadLine();
            number = int.Parse(inputValue);

            if ((number % Two) == 0)
            {
                //true path coding block
                //true means the condition on the if statement is true
                Console.WriteLine($"Your number {number} is even.");
                Console.WriteLine("Your number {0} is even", number);
                Console.WriteLine("Your number " + number + " is even");
            }
            else
            {
                //false path coding block
                //false means the condition on the if statement is false
                Console.WriteLine($"Your number {number} is odd.");
            }//eof
        }//eom
    }//eoc
}//eon