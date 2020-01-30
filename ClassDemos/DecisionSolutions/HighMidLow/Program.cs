using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighMidLow
{
    class Program
    {
        static void Main(string[] args)
        {
            //to save time in the demo, the test values will be hard coded instead of prompt/read
            int num1 = 5;
            int num2 = 9;
            int num3 = 6;
            int high, mid, low;
            //assume one of the numbers is the highest
            high = num1;

            if (num2 > high)
            {
                string codeblock2T = "level 2T coding block";
                high = num2; //new highest number
                if (num3 > high)
                {
                    string codeblock3T = "level 3T coding block";
                    high = num3;
                    mid = num2;
                    low = num1;
                    Console.WriteLine(codeblock3T);
                    Console.WriteLine(codeblock2T);
                    //Console.WriteLine(codeblock4T); outside the current/parent codeblock
                }//goes to WriteLine at end of nested if
                else
                {
                    string codeblock3F = "level 3F coding block";
                    if (num3 > num1)
                    {
                        string codeblock4T = "level 4T coding block";
                        mid = num3;
                        low = num1;
                        //codeblock4T was declared within this codeblock
                        //codeblock4T is deemed "alive"
                        //the existence of codeblock4T (or any variable) is called "variable scope"
                        Console.WriteLine(codeblock4T);
                        //codeblock 4T dies at the end of its codeblock
                        //when a variable goes out of scope (dies), the value/contents die with it
                    }//goes to WriteLine at end of nested if
                    else
                    {
                        string codeblock4F = "level 4F coding block";
                        mid = num1;
                        low = num3;
                        Console.WriteLine(codeblock2T);
                    }//goes to WriteLine at end of nested if
                }
            }
            else
            {
                if (num3 > high)
                {
                    high = num3;
                    mid = num1;
                    low = num2;
                }//goes to WriteLine at end of nested if
                else
                {
                    if (num3 > num2)
                    {
                        mid = num3;
                        low = num2;
                    }//goes to WriteLine at end of nested if
                    else
                    {
                        mid = num2;
                        low = num3;
                    }//goes to WriteLine at end of nested if
                }
            }//end of the nested if
            Console.WriteLine($"num1 {num1} num2 {num2} num3 {num3} order is high {high} mid {mid} low {low}");
            Console.ReadKey();
        }
    }
}
