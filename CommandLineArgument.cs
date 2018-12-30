using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgument
{
    class Program
    {
        static void Main(string[] args)
        {

            // To check the length of  
            // Command line arguments   
            if (args.Length > 0)
            {
                Console.WriteLine("Arguments Passed by the Programmer:");

                // To print the command line  
                // arguments using foreach loop 
                foreach (Object obj in args)
                {
                    Console.WriteLine(obj);
                }
            }

            else
            {
                Console.WriteLine("No command line arguments found.");
            }
        }
    }
}
