using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prjOOPS
{
    // default access specifier for variable is internal
    internal class Person
    {
        //variable --default access specifier for variable and method is private
        //Instances
        string name, city;
        int age;

        //methods or function
/*access specifier or modifier runtime methodname(paralist)
 {
   code
 }*/

        void GetData()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your city");
            city = Console.ReadLine();

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());//Explicit type conversion
        }
        void PrintUserData()
        {
            Console.WriteLine("Name:{0} || city:{1} || Age:{2}", name, city, age);
        }
        static void Main()
        {
            Person p = new Person();
            p.city = "chenai";//instance variable
            p.GetData();
            p.PrintUserData();
            Console.Read();
        }
    }
}



