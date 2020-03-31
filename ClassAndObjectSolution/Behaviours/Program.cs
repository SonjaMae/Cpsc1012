using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviours
{
    class Program
    {
        static void Main(string[] args)
        {
            Window[] myWindows = new Window[10];
            Window theInstance = null;
            int logicalSize = 0;
            try
            {
                theInstance = new Window(); //default constructor
                theInstance.Model = "2 pane gas filled";
                myWindows[logicalSize] = theInstance;
                logicalSize++;

                theInstance = new Window("single pane plexiglass", 2.1, 1.0); //greedie constructor
                myWindows[logicalSize] = theInstance;
                logicalSize++;

                theInstance = new Window(); //default constructora and overriding the default values
                theInstance.Model = "2 pane tinted";
                theInstance.Height = 1.75;
                theInstance.Width = 3.2;
                myWindows[logicalSize] = theInstance;
                logicalSize++;

                //display the instances of the array
                for (int i = 0; i < logicalSize; i++)
                {
                    Console.WriteLine(myWindows[i].ToString());

                    //let's play with the class behaviours:
                    Console.WriteLine("\n\nBehaviours\n");
                    Console.WriteLine($"Area: {myWindows[i].Area()}");
                    Console.WriteLine($"Perimeter: {myWindows[i].Perimeter()}");
                    Console.WriteLine($"Estimate: {myWindows[i].Estimate(14.95,2)}\n\n");
                }

                theInstance = new Window(); //bad width, looking for an exception
                theInstance.Model = "bad width";
                theInstance.Height = 1.75;
                theInstance.Width = -3; //error
                myWindows[logicalSize] = theInstance;
                logicalSize++;
                Console.WriteLine(myWindows[logicalSize - 1].ToString()); //unreachable code because of the prior error
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
