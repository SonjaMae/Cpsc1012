using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeLetter = "c";
            string percentageRange;

            //a case structure can be used when you have a single argument compared to a series of literal values
            //the structure begins with switch(argument value) {...}
            //within the switch structure you have "cases"
            //a case represents one "if" test against the argument value
            //the case must end with a "break;" command
            //the "break" sends your execution to the end of the switch structure
            //the last case in your switch is a special case called "default"
            //"default" does not test against a literal value
            //default executes if none of the previous cases were executed
            //you can have multiple case statewments coded for a particular case coding block
            //multiple case statements for a particular case coding block are implied logical or (||) tests
            //the case test is a relational equal (==) test

            //switch(gradeLetter)
            //{
            //    case "a":
            //    case "A":
            //        {
            //            //logic for this particular case
            //            percentageRange = "85 - 100";
            //            break;
            //        }
            //    case "b":
            //    case "B":
            //        {
            //            //logic for this particular case
            //            percentageRange = "75 - 84";
            //            break;
            //        }
            //    case "c":
            //    case "C":
            //        {
            //            //logic for this particular case
            //            percentageRange = "55 - 69";
            //            break;
            //        }
            //    case "d":
            //    case "D":
            //        {
            //            //logic for this particular case
            //            percentageRange = "40 - 54";
            //            break;
            //        }
            //    case "f":
            //    case "F":
            //        {
            //            //logic for this particular case
            //            percentageRange = "0 - 39";
            //            break;
            //        }
            //    default:
            //        {
            //            //the implied test on this case is "none of the above"
            //            percentageRange = "an invalid letter grade!";
            //            break;
            //        }
            //}//eos


            switch (gradeLetter.ToUpper())
            {
                case "A":
                    {
                        //logic for this particular case
                        percentageRange = "85 - 100";
                        break;
                    }
                case "B":
                    {
                        //logic for this particular case
                        percentageRange = "75 - 84";
                        break;
                    }
                case "C":
                    {
                        //logic for this particular case
                        percentageRange = "55 - 69";
                        break;
                    }
                case "D":
                    {
                        //logic for this particular case
                        percentageRange = "40 - 54";
                        break;
                    }
                case "F":
                    {
                        //logic for this particular case
                        percentageRange = "0 - 39";
                        break;
                    }
                default:
                    {
                        //the implied test on this case is "none of the above"
                        percentageRange = "an invalid letter grade!";
                        break;
                    }
            }//eos
            Console.WriteLine($"Your grade letter ({gradeLetter}) is {percentageRange}.");
            Console.ReadKey(); //when using debugging to stop the auto close of your display



            Console.WriteLine("\n\n");
            //another example:
            int monthNumber = 4;

            //there is a single arugment variable
            //this single argument variable will be tested against multiple constant values
            //the case test is an == test ONLY (every other kind of test requires if-elses)

            switch (monthNumber)
            {
                case 1:
                    {
                        //any logic that is required when monthNumber is 1 goes here
                        Console.WriteLine("The name of the month is January.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The name of the month is February.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("The name of the month is March.");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("The name of the month is April.");
                        break;
                    }
                default:
                    {
                        //this logic is done if one of the previous cases wasn't executed
                        Console.WriteLine("Too late in the year to think anymore");
                        break;
                    }
            }//eos
            Console.ReadKey();
        }
    }
}
