using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FileIOBrowseDialog
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

            string readValue = "";

            int counter = 0;



            StreamReader reader = null;
            try
            {

                reader = new StreamReader(Full_Path_File_Name);

                readValue = reader.ReadLine();


                while (readValue != null)
                {
                    counter++;
                    //Console.WriteLine($"File line {counter} has a value of {readValue}\n");


                    //you must know how the indivdual values are separated on the file line (file record)
                    //many times this is done using a comma (,)
                    //files that use a comma are generally referred to as comma separated values (csv)
                    //each line that is read is processed through a loop to extract each value
                    //a system method exists which allows one to split the values apart
                    //this method is .Split('delimiter')
                    //the delimiter is the character used to separate the values on the file record
                    int columncounter = 0;
                    foreach (var columnitem in readValue.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Row {counter} Column {columncounter} has a value of {columnitem}");
                    }


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


            Console.ReadKey();
        }
    }
}
