using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the .Replace(char, char) string method (replacing a character with another character)
            string myString = "CPSC 1012 Fundamental Programming";
            string inputString = "";
            char oldchar;
            char newchar;
            string oldstring = "";
            string newstring = "";

            //some string functions:
                //myString.Length();
                //myString.Split();
                //myString.Trim();
                //myString.Contains(); // very similar to using IndexOf but IndexOf actually returns the location index of the value if it is contained in the searched value
                //myString.Reverse();

            do
            {
                inputString = GetString("Get character you wish to replace");

                if (!inputString.Equals("-1"))
                {
                    Console.Write($"Your old string is {myString}");
                    oldchar = char.Parse(inputString);
                    oldstring = inputString;
                    inputString = GetString("Get new character you wish replace it with");
                    newchar = char.Parse(inputString);
                    newstring = inputString;
                    //.Replace() will replace any occurance of the old character with the specified replacement character
                    //.Replace() returns its work as a string
                    //you need to receive the string on the left side (an assignment statement)
                    myString = myString.Replace(oldchar, newchar);
                    myString = myString.Replace(oldstring, newstring);
                    //in this case, to remove case sensitivity, ToUpper or ToLower must be used
                    Console.WriteLine($"Your new string is {myString}");
                }
            } while (!inputString.Equals("-1"));
            Console.ReadKey();
        }
        static string GetString(string prompt)
        {
            Console.WriteLine($"{prompt}\t");
            string input = Console.ReadLine();
            return input;
        }

    }
}
