using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAndObject;
using System.IO;
using Microsoft.Win32;

namespace ConstructorsAndList
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //List<T> is an instance class
            //T stands for datatype
            //the class will hold different data from a second List<T>
            List<Assessment> StudentList = new List<Assessment>();


            //default Assessment constructor
            Assessment defaultItem = new Assessment();
            //fill it
            defaultItem.FirstName = "sonja";
            defaultItem.LastName = "holowaychuk";
            defaultItem.Mark = 100;
            defaultItem.AssessmentName = "default";

            StudentList.Add(defaultItem);


            //greedie constructor
            Assessment greedieItem = new Assessment("bob","harry","greedie", 35.6, "greed never pays");

            StudentList.Add(greedieItem);

            //foreach(Assessment item in StudentList)
            //{
            //    Console.WriteLine($"Name: {item.LastName}, { item.FirstName }, Assessment: {item.AssessmentName}, Mark: {item.Mark}, Comment: >{item.Comment}<");
            //}

            //for (int i = 0; i < StudentList.Count; i++)
            //{
            //    Console.WriteLine($"Name: {StudentList[i].LastName}, { StudentList[i].FirstName }, Assessment: {StudentList[i].AssessmentName}, Mark: {StudentList[i].Mark}, Comment: >{StudentList[i].Comment}<");
            //}

            Console.WriteLine($"\n\n/File reading, list loading, using Assessment class\n");

            ReadAndLoadList(StudentList);
            foreach (Assessment item in StudentList)
            {
                Console.WriteLine($"Name: {item.LastName}, { item.FirstName }, Assessment: {item.AssessmentName}, Mark: {item.Mark}, Comment: >{item.Comment}<");
            }
        }

        static void ReadAndLoadList(List<Assessment> StudentList)
        {
            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readvalue = "";
            StreamReader reader = null;
            //create a "parking space" for an instance of the class Assessment
            Assessment theInstance = null;
            int column = 0; //this is used to indicate which column on the incoming record
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readvalue = reader.ReadLine();
                while (readvalue != null)
                {
                    column = 0; //reset for the next record
                    //create a new instance for the incoming record
                    theInstance = new Assessment(); //using default constructor
                    foreach (string item in readvalue.Split(','))
                    {
                        switch (column)
                        {
                            case 0:
                                {
                                    //this is the first column on the record
                                    //get first and last name
                                    //it's one column on the record
                                    //we need to divide the data into 2
                                    //the first and last name are separated by a space
                                    int firstlastspace = item.IndexOf(' ');
                                    theInstance.FirstName = item.Substring(0, firstlastspace);
                                    theInstance.LastName = item.Substring(firstlastspace + 1);
                                    break;
                                }
                            case 1:
                                {
                                    //this is the second column on the record
                                    theInstance.AssessmentName = item;
                                    break;
                                }
                            case 2:
                                {
                                    //this is the third column on the record
                                    theInstance.Mark = double.Parse(item);
                                    break;
                                }
                            default:
                                {
                                    //this is the fourth column on the record
                                    theInstance.Comment = item;
                                    break;
                                }
                        }
                        column++;
                    }
                    StudentList.Add(theInstance);
                    //get the next line
                    readvalue = reader.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
