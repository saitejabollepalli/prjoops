using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPS
{
    internal class StaticEg
    {
        public string sname { get; set; }

        public string dept { get; set; }

        //static variable
        internal static string collegename;
        
        //static constructor
        static Student()
        {
            Console.WriteLine("static Constructor");
            collegename = "MIT";
        }
        internal Student (string sname,string,dept)
        {
            Console.WriteLine("Constructor");
            //this refer to current class instance variable
        }
        internal void PrintData()
        {
            Console.WriteLine("Name:{0} || Dept:{1} || CollegeName:{2}", sname, dept, collegename);
        }
        internal static float studentAverage(int total,int noofsubjects)
        {
            float average = total / noofsubjects;

            return average;
        }
    }
    class StaticEg
    {
        public void Main()
        {
            Student student = new Student("Anu,CSE");
            student.PrintData();
            Student student = new Student("Banu,EEE");
            student1.PrintData();

        }
}
