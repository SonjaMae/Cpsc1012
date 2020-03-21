using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace ArrayUtilities
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int[] driverArray = new int[25];
            int[] tempArray = new int[25];
            int logicalsize = ReadandLoadArray(driverArray, 25); //calling statement

            //sort ascending the contents of an array:
            LoadWorkingArray(driverArray, tempArray);
            SortAscending(tempArray, logicalsize);

            //sort descending the contents of an array:
            LoadWorkingArray(driverArray, tempArray);
            SortDescending(tempArray, logicalsize);

            //find an element in an array:
            LoadWorkingArray(driverArray, tempArray);
            FindElement(tempArray, logicalsize, 35);
            FindElement(tempArray, logicalsize, 4);
            FindElement(tempArray, logicalsize, 39);
        }

        static int ReadandLoadArray(int[] myArray, int physicalsize)
        {
            //pass to your method the array referenced address

            //changes to the array within this method will alter the ORIGINAL array in the Main() method
            //physicalsize is pass by Value (a copy of the original value)
            //any change to the physicalsize REMAINS within this method and DOESN'T alter the original value in Main()

            int logicalsize = 0;

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
            return logicalsize;
        }

        static void LoadWorkingArray(int[] originalArray, int[] workingArray)
        {
            //create a physical copy of the array:
            int index = 0;
            //foreach loop is a pre-test while
            //it stars with the first item in your collection (in this case an array)
            //item is an instance of the collection (array element)
            //the coding block {...} uses the "item" to use the current instance of the collection
            //the loop automatically moves to the next item in your collection
            //the loop automatically stops after the last item in your collection
            //the loop precesses the whole collection start to end
            foreach(var item in originalArray)
            {
                workingArray[index] = item;
                index++;
            }
        }

        static void DisplayArray(int[] theArray, int logicalsize)
        {
            Console.WriteLine($"Current values in the array, size {logicalsize}");
            string msg = "";
            for(int i = 0; i < logicalsize; i++)
            {
                msg += theArray[i] + ", ";
            }
            msg = msg.Substring(0, msg.Length - 2);
            Console.WriteLine(msg);
        }

        static void SortAscending(int[] theArray, int logicalsize)
        {
            Console.WriteLine("\n\nArray: Sort Ascending\n");
            DisplayArray(theArray, logicalsize);
            //sort the array:
            //use the method .Sort()
            //using .Sort(array) sorts the entire array
            //using .Sort(array, start index value, array length) sorts from element at index n for x elements
            Array.Sort(theArray, 0, logicalsize);
            DisplayArray(theArray, logicalsize);
        }

        static void SortDescending(int[] theArray, int logicalsize)
        {
            Console.WriteLine("\n\nArray: Sort Descending\n");
            DisplayArray(theArray, logicalsize);
            //<datatype> identifies the datatype that is being used
            //new creates an instance of a class called Comparison<datatype>()
            //to represent any 2 items in your collection, use a placeholder (like x,y)
            //=> means "do the following for x,y"
            //x.CompareTo(y) is an ascending sort
            //y.CompareTo(x) is a descending sort
            Array.Sort<int>(theArray, new Comparison<int>((x, y) => y.CompareTo(x)));
            DisplayArray(theArray, 25);
        }

        static void FindElement(int[] theArray, int logicalsize, int elementArgument)
        {
            Console.WriteLine("\n\nArray: Find Element\n");
            DisplayArray(theArray, logicalsize);
            //.IndexOf(array, searchvalue) searches the entire array
            //.IndexOf(array, searchvalue, start index, number of elements) searches part of the array
            //if element arg is found, returns the index of that location (1st occurance)
            //if element arg is NOT found, return -1
            int foundindex = Array.IndexOf(theArray, elementArgument, 0, logicalsize);
            if (foundindex < 0)
            {
                //NOT found
                Console.WriteLine($"Your search value {elementArgument} is not found in the array.");
            }
            else
            {
                //found
                Console.WriteLine($"Your search value {elementArgument} is found in the array at index {foundindex}.");
            }
        }
    }
}
