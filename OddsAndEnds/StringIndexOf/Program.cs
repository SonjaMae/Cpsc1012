using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the location of a string within another string
            //to do that, use the method .IndexOf()

            //use psuedo code (statements) to organize your thoughts before you start coding:

            //need an original string
            //declare any variables
            //do
                //get string to look for
                //find query string in original string
                //test if found:
                    //if no: not found message
                    //if yes: display index where found in original string
            //while not to stop

            string myString = "CPSC 1012 Fundamental Programming";
            int startPosition = 0;
            string inputString = "";
            int indexAt = 0;
            do
            {
                inputString = GetString();
                //to find a string in another string:
                //findinstring.IndexOf(querystring, start index position [.Length()])
                //if the querystring is found in findinstring, the result will be an index of 0 or more
                //only the first occurance of the querystring has the index returned, dependant on the start location
                //if the querystring is not found in findinstring, the result is -1
                //indexAt is case sensitive through use of (StringComparison.OrdinalIgnoreCase)
                indexAt = myString.IndexOf(inputString, startPosition, StringComparison.OrdinalIgnoreCase);
                //could also be written as:
                //indexAt = myString.ToUpper().IndexOf(inputString.ToUpper(), startPosition, StringComparison.OrdinalIgnoreCase);
                if (!inputString.Equals("-1")) //test to see if i quit
                {
                    if (indexAt < 0) //means it was not found
                    {
                        Console.WriteLine($"{inputString} not found in {myString}");
                    }
                    else
                    {
                        Console.WriteLine($"{inputString} was found in {myString} at index {indexAt}");
                    }
                }
            } while (!inputString.Equals("-1"));
            Console.ReadKey();
        }
        static string GetString()
        {
            Console.Write("Enter query string:\t");
            string input = Console.ReadLine();
            return input;
        }
        //if you want to find more than the first one, you would need to loop with the startPosition changed to be the next character in the string after the found index
    }
}
