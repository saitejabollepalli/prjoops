using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPS
{
    internal class organization
    {
        //prooerties
        public string orgname { get; set; }
        //read -only property
        public int orgid { get; private set; } //get is public set is private

        //read -only property
        public string registrationno { get; }

        string[] orglocation = { "chennai", "mumbai", "pune" }; //Array

        //default constructor
        internal organization()
        {
            Console.WriteLine("I am a default constructor");
        }
        //constructor overloading
        internal organization(string oname)
        {
            orgid = 1001;
            registrationno = "Org90";
            orgname = oname;
        }

        internal void Display()
        {
            Console.WriteLine("orgid:{0} || orgname:{1} || registrationno:(2)", orgid, orgname, registrationno);
            foreach (string loc in orglocation)
            {
                Console.WriteLine(loc);
            }
        }



    }
    class CompanyInfo
    {
        static void Main()
        {
            organization organization = new organization();
            // organization.id=100 //error since it is private
            organization.orgname = "LTI";
            Console.WriteLine("calling by object 1");
            organization.Display();
            Console.WriteLine("caling by object2");
            organization o2 = new organization("ABC");
            o2.Display();

            Console.Read();
        }
    }
}
    

