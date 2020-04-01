using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace ParallelArrays
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //array sizing happens when you create the array
            int physicalArraySize = 25;
            int[] driverArray = new int[physicalArraySize];
            string[] nameArray = new string[physicalArraySize];

            //the call statement to your method must match the parameter list of your method
                //example: three parameters, three arguments
            //arguments on the call statement are positional
            int logicalsize = ReadandLoadArray(driverArray, physicalArraySize, nameArray);
            int sum = 0;

            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];
            }

            if (logicalsize > 0)
            {
                
                Console.WriteLine($"Quiz Total: {logicalsize}");
                Console.WriteLine($"Student             Mark");
                Console.WriteLine($"_______________     ____");

                int index = 0;
                while (index < logicalsize)
                {
                    Console.Write($"{nameArray[index],-15}");
                    Console.WriteLine($"{driverArray[index]}".PadLeft(9));
                    index++;
                }
                FindHighandLow(driverArray, logicalsize);

                Console.WriteLine($"The average of the {logicalsize} numbers is {(double)sum / (double)logicalsize}");
            }
            else
            {
                Console.WriteLine($"You have no numbers to calculate an average with");
            }
        }
        static int ReadandLoadArray(int[] myArray, int physicalsize, string[] nameArray)
        {
            //pass to your method the array referenced address

            //changes to the array within this method will alter the ORIGINAL array in the Main() method
            //physicalsize is a pass-by value (a copy of the original value)
            //any change to the physicalsize REMAINS within this method and DOESN'T alter the original value in Main()

            int logicalsize = 0;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readRecord = "";
            StreamReader reader = null;

            //recordDataColumn will be a counter indicating which column on the currently read record we are dealing with
            //on the record, each column of data will be separated by a ,
                //two column record example:        Candy Kane, 44
                //three column record example:      Candy Kane, CPSC1012, 44
            int recordDataColumn = 0;
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readRecord = reader.ReadLine();

                while (readRecord != null && logicalsize < physicalsize)
                {
                    //store the data into the program variables
                    //how does one split the record into separate data columns?
                    //the record is a string
                    //the data on the string is separated by a ,
                    //you can use the string class method called .Split(delimiter)
                    //the delimiter is the character used to separate the data values
                    //.Split(',') returns an array of strings

                    //pre-test loop: foreach()
                    //syntax: foreach(datatype placeholdername in collection)
                    //datatype can be a strongly declared datatype (example: int, double...)
                    //or you can use the declaratyion of var
                    //a var datatype is resolved at execution time
                    //placeholdername is your variable name that you will use in your code to reference the current occurance of the data you're processing
                    //in is a keyword
                    //the collection is your original data collection

                    //why use foreach?
                    //this method will:
                        //a) check if there is any need to process the loop
                        //b) automatically move to the next occurance in the collection
                        //c) automatically stop when it reaches the end of the collection
                        //d) process an unknown number of items
                        //e) start at the beginning of your collection and go to the end
                        //f) your collection can be of any datatype, as long as it's a collection and not just a single value (an array is a collection)

                    foreach(var item in readRecord.Split(','))
                    {
                        if (recordDataColumn == 0)
                        {
                            //name
                            nameArray[logicalsize] = item;
                        }
                        else
                        {
                            //mark
                            myArray[logicalsize] = int.Parse(item);
                        }
                        //switch the record data collection indicator
                        recordDataColumn = 1;
                    }
                    logicalsize++;
                    //to get ready for the next record, reset your recordDataColumn indicator back to 0
                    recordDataColumn = 0;
                    //get the next line
                    readRecord = reader.ReadLine();
                }
            } //eof try

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return logicalsize;
        }

        static void FindHighandLow(int[] myArray, int logicalsize)
        {
            int highest = 0;
            int lowest = 100;
            int loopCounter = 0;
            while (loopCounter < logicalsize)
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
            Console.WriteLine($"highest mark is {highest}");
            Console.WriteLine($"lowest mark is {lowest}");
        }
    }
}
