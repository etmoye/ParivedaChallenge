using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pariveda_Challenge
{
    class Students
    {
        public string studentName;
        public string studentCwid;
        public string studentClass;
        public string studentEmail;

        public static int count;

        public Students(string studentName, string studentCwid, string studentClass, string studentEmail)
        {
            this.studentName = studentName;
            this.studentCwid = studentCwid;
            this.studentClass = studentClass;
            this.studentEmail = studentEmail;
        }
        public Students()
        {

        }

        public string GetStudentName()
        {
            return studentName;
        }
        
        public void SetStudentName(string studentName)
        {
            this.studentName = studentName; 
        }

        public string GetStudentCwid()
        {
            return studentCwid;
        }

        public void SetStudentCwid(string studentCwid)
        {
            this.studentCwid = studentCwid;
        }
        public string GetStudentClass()
        {
            return studentClass;
        }

        public void SetStudentClass(string studentClass)
        {
            this.studentClass = studentClass;
        }

        public string GetStudentEmail()
        {
            return studentEmail;
        }

        public void SetStudentEmail(string studentEmail)
        {
            this.studentEmail = studentEmail;
        }


        public string ToFile()
        {
            return studentName + '-' + studentCwid + '-' + studentClass + '-' + studentEmail; 
        }

        public static int GetCount()
        {
            return count;
        }

        //do not use this. for class vari
        public static void SetCount(int count)
        {
            Students.count = count;
        }
        public static void IncCount()
        {
            Students.count++;
        }

        public override string ToString()
        {
            return this.studentName;
        }

    }
}
