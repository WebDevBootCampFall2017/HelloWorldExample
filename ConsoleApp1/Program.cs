using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many eggs would you like?");
            string s = Console.ReadLine();
            try
            {
                int n = int.Parse(s);
                Console.WriteLine("Here are {0} eggs.  Have a nice day!", n);
            }
            catch (Exception e)
            {
                Console.WriteLine("That's not a number");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
