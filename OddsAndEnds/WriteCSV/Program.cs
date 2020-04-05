using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteCSV //CSV = comma separated values
{
    class Program
    {
        static void Main(string[] args)
        {
            //you'll need:
            //using System.IO
            //a location (can be using an absolute path, using find your special directory path, or using a FileOpenDialogue)
            //StreamWriter to handle the outgoing data

            //by default, files are replaced
            //however, you can add a parameter to the StreamWriter that indicates appending or not
            //append:true means that you're adding to the file, and is the default setting for append:
            //if the file doesn't exist, it will be created
            // \ is a special character so to get it to make a single \  you need the \\
            StreamWriter writer = new StreamWriter($"c:\\desktop\\outputfile.txt", append:true);
            writer.WriteLine("Sonja Holowaychuk, CPSC1012, 98");
            writer.Close();
            writer = new StreamWriter($"c:\\desktop\\outputfile.txt");
            writer.WriteLine("Shirley Ujest, CPSC1012, 98");
            writer.Close();
            writer = new StreamWriter($"c:\\desktop\\outputfile.txt");
            writer.WriteLine("Lowand Behold, CPSC1012, 40");
            writer.Close();

            //if given a proper path, this code would create a .txt file with the information entered using StreamWriter
        }
    }
}
