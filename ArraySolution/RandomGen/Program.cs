using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGen
{
    class Program //your Program is an object
    {
        //if declared outside of a method, add the keyword static in front of your declaration
        //static Random rnd = new Random();

        //if declared outside of a method BUT within the class, then the variable is known to all methods without having to pass the value as a parameter
        //(that would negate methods, so don't declare outside of a method but within the class for core portfolio assignment 4)
        static void Main(string[] args)
        {
            //Random is a datatype of class (a class is an object and also a datatype)
            //Random is just the definition of the object, not a physical instance of the object
            //to get a physical instance of the object, use the keyword new
            //new is used by any object to create an instance of that object
            //to identify the object instance datatype, add the class name after the keyword new
            //Random is the datatype
            //rnd is the variable name of the object instance
            //new is the command keyword to create an object instance
            //Random() is the type of object instance new is to create

            Random rnd = new Random();
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = rnd.Next(1, 100);
                    Console.WriteLine($"index {i} has a value of {myArray[i]}");
            }


            //how to find the highest and lowest random number generated:

            int highest = 0;
            int lowest = 100;
            int loopCounter = 0;
            while (loopCounter < 10)
            {
                if (highest < myArray[loopCounter])
                {
                    highest = myArray[loopCounter];
                }
                if (lowest > myArray[loopCounter])
                {
                    lowest = myArray[loopCounter];
                }
                loopCounter++;
            }
            Console.WriteLine($"highest value is {highest}");
            Console.WriteLine($"lowest value is {lowest}");
        }

        static void SomeMethod (Random paramRnd)
        {
            //you can pass whatever you want into a method as long as you've used a matching datatype and variable name
        }
    }
}
