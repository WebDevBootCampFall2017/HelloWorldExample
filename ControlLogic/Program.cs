using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many eggs would you like?");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            Console.WriteLine("Here are {0} eggs.  Have a nice day!", n);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
