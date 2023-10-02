using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Singletons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get an instance of the Logger class
            Logger l1 = Logger.GetInstance();
            Logger l2 = Logger.GetInstance();
            // Log some messages
            l1.logs("This is first log");
            l2.logs("This is second log");

            //Checking instances if it's single or not.
            if (l1 == l2)
            {
                Console.WriteLine("Only one instance was created!");
            }
            else
            {
                Console.WriteLine("It didn't work at all");
            }
        }
    }
}
