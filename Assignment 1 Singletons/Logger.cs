using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Singletons
{
    // Define the Logger class
    public class Logger
    {
        private static Logger _instance;

        // Private constructor to prevent instantiation from other classes
        private Logger()
        {
        }

        // Public method to get the singleton instance of Logger
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        // Public method to log a message
        public void logs(string message)
        {
            Console.WriteLine(message);
        }
    }
}
