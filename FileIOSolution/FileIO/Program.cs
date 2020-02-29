using Microsoft.Win32; //required for the OpenFileDialog
using System;
using System.Collections.Generic;
using System.IO; //required to do File I/O (StreamReader)
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    
    class Program
    {
        //this si required for your code when using OpenFileDialog
        [STAThread]
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";

            //you can prompt for the file name

            //~~~~~~~~~~~~~~~~~
                    //set up the location:

            //the file will always be in the same location
            //specify the file path name
            //string FolderPath = @"C:\Users\sholowaychuk2\Documents\GitHub\Cpsc1012\";


            //~~~~~~~~~~~~~~~~~~~
            //use methods within the software to access the general special folders of your Windows file system
            //(like Documents, Downloads, Pictures, Music, etc.)

            //this GetFolderPath will return C:\Users\xxxx\the special foldername
            //for the following statement it will be C:\Users\sholowaychuk2\Documents
            string specialpathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //now you must add any additional path structure to get to the specific folder within the special folder:
            //string FolderPath = specialpathname + @"\GitHub\Cpsc1012\";


            //assume that the required file will always be found at the root of the course class repository
            //Console.WriteLine("Enter the file name (example: my file.txt)");
            //string FileName = Console.ReadLine();

            //Full_Path_File_Name = FolderPath + FileName;
            //~~~~~~~~~~~~~~~~~~

            //the best way to do it:

            //is there a way to browse for a file?
            //yes. you can call the OpenFileDialog
            //this is the dialog window that you see on your system when you for a file within an application
            //how to browse for a file:
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            //~~~~~~~~~~~~~~~~~~


            //set up for reading a file:

            //a string variable is required to receive the data from the file
            //the string will be filled with one row from your file on each file read
            string readValue = "";

            //use a variable to count the rows in the file (optional)
            int counter = 0;
            //~~~~~~~~~~~~~~~~~~~~


            //include what is referred to as "User Friendly error handling"
            //this is your try/catch/finally structure
            //the finally portion is only needed if you need to close a connection to a data source (in this case, to a file)
            StreamReader reader = null;
            try
            {
                //in the try is the code you will attempt to execute
                //if an error happens during the execution of the code, an Exception is thrown by the system
                //any Exception thrown by the system is passed to the catch{} coding block for processing

                //to test the try/catch, I will introduce a bad path name
                Full_Path_File_Name = @"C:\Users\sholowaychuk2\Documents\GitHub\Cpsc1012\badpathname.txt";

                //add the .Net Framework class that contains the code that will do the read of the file
                //the require I/O class for reading is StreamReader located in the namespace System.IO
                //to attach the reader to the file, you need to pass the full path file name (fully qualified file name) as an argument to the class while it is being created
                //the reader is referred to as an instance of the class StreamReader
                //the instance is physically created when the new command is used in conjunction with the class name
                reader = new StreamReader(Full_Path_File_Name);


                //ReadLine gets a single row of the file
                readValue = reader.ReadLine();

                //if your line that was "read" is null, you have reached the end of the file (eof)
                while (readValue != null) //stop when your reach the end of the file
                {
                    counter++;
                    Console.WriteLine($"File line {counter} has a value of {readValue}\n");

                    //get the next line
                    readValue = reader.ReadLine();
                }
            }//eof try
            catch (Exception ex)
            {
                //if an error happens in the try, the catch code block is run

                //.Message holds the error uccured during the processing of the code in your try{....}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                //the finaqlly code block is used if you need to close a data source (such as an open file)

                reader.Close();
            }

            Console.ReadKey();
        }
    }
}
