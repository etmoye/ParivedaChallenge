using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pariveda_Challenge
{
    class StudentUtilities
    {
        Students[] viewStudent;

        public StudentUtilities()
        {
          
        }

        //public StudentUtilities(Students[] temp)
        //{
        //    this.viewStudent = temp;
        //}


        public static void GetAllStudents()
        {
            Students.SetCount(0);
            Students[] viewStudent = new Students[100];
            StreamReader inFile = new StreamReader("CurrentStudents.txt");

            string input = inFile.ReadLine();

            while (input != null)
            {
                string[] tempArray = input.Split('-');
                viewStudent[Students.GetCount()] = new Students(tempArray[0], tempArray[1], tempArray[2], (tempArray[3]));
                Students.IncCount();

                input = inFile.ReadLine();
            }

            inFile.Close();

        }

        public void SaveStudents()
        {
            //Listing[] viewListings = new Listing[100]; // creates new blank array??
            //Listing.SetCount(0);

            StreamWriter outfile = new StreamWriter("CurrentStudents.txt"); //("output.txt", true) use if you want to pick up a file where you left off
            outfile.WriteLine(viewStudent + " should show student");
            for (int i = 0; i < 10; i++) //fix limit - JUST FOR TESTING 
            {
                //VIEWSTUDENT HAS NO VALUE
               // outfile.WriteLine("is this getting here"); - IS NOT GETTING HERE
                //outfile.WriteLine(viewStudent[i].ToFile());
                //outfile.WriteLine(
                //Listing.IncCount();

            }
            //outfile.Write(viewStudent[Students.GetCount() - 1].ToFile());

            outfile.Close();
        }
       
    }
}
