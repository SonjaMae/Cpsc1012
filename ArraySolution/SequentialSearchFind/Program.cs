using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileIOBrowseDialog
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            //declare an integer array of 25 elements
            int[] myArray = new int[25];
            //integer variable to indicate the logical size of the array
            //the logical size refers to the number of elements in the array
            //the declared size (25) is referred to as the physical size
            int logicalsize = 0;
            int physicalsize = 25;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readValue = "";

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();


                while (readValue != null && logicalsize < physicalsize)
                {
                    myArray[logicalsize] = int.Parse(readValue);
                    logicalsize++;
                    //get the next line
                    readValue = reader.ReadLine();
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
            Console.WriteLine($"The number of elements in the array is {logicalsize}");

            for (int loopcounter = 0; loopcounter < logicalsize; loopcounter++)
            {
                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");
            }

            //sequential search:
            //is it there?

            Console.Write($"Enter a number:\t");
            int searchargument = int.Parse(Console.ReadLine());

            bool found = false;
            int searchindex = 0;

            //condition expression:
            //  a) continue to look until you've looked at everything
            //  b) continue if not found

            //searchcounter is an index, which means it is 0 based
            //logical size is a natural counter, which means it is 1 based

            while (searchindex < logicalsize && !found)
            {
                if (myArray[searchindex] == searchargument)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where the searchargument was first found
                    found = true;
                }
                else
                {
                    //increment to look at t5he next element in the array
                    searchindex++;
                }
            }
            if(found)
            {
                Console.WriteLine($"{searchargument} was found at index {searchindex}");
            }
            else
            {
                Console.WriteLine($"{searchargument} was not found anywhere in the {logicalsize} array elements");
            }


            //count the number of occurances in the array
            searchindex = 0;
            int foundcount = 0;
            found = false;

            //this could also be coded using a for loop because you're looking at all the elements (exact count)
            // for (int searchindex = 0; searchindex < logicalsize; searchindex++)
            //for loops are best used when you know exactly how many iterations of the loop will occur

            //you don't want to stop once you find the first occurance in the loop, so remove && !found from the loop statement
            while (searchindex < logicalsize)
            {
                if (myArray[searchindex] == searchargument)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where the searchargument was first found
                    found = true;
                    foundcount++;
                }

                //increment to look at t5he next element in the array
                searchindex++;
            }

            //this could also be coded without the if (found) boolean flag:
            //if (foundcount > 0)

            if (found)
            {
                Console.WriteLine($"{foundcount} occurances of {searchargument} were found in the array");
            }
            else
            {
                Console.WriteLine($"{searchargument} was not found anywhere in the {logicalsize} array elements");
            }
        }

    }
}