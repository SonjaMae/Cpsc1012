using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int first;                      //declare and default to 0
            int second;                     //decalre and default to 0
            int highest = -99;              //decalre and set to -99
            string message;                 //decalre and default to null
            string inputValue;

            Console.Write("Enter first number:\t");
            inputValue = Console.ReadLine();
            first = int.Parse(inputValue);

            //reuse inputValue because the previous contents of inputValue have been stored elsewhere
            System.Console.Write("Enter second number:\t");
            inputValue = Console.ReadLine();
            second = int.Parse(inputValue);

            if(first > second)
            {
                //true path coding block
                //true means the condition on the if statement is true
                highest = first;
                message = "first";
            }
            else
            {
                //false path coding block
                //false means the condition on the if statement is false
                highest = second;
                message = "second";
            }//eof
            Console.WriteLine($"First = {first}, Second = {second}" +
                $", the {message} number entered had the higher value: {highest}");
            Console.ReadKey();
        }//eom
    }//eoc
}//eon
