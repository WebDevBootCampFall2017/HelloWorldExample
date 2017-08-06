using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            int n = 0;
            bool can_convert = false;
            do
            {
                Console.WriteLine("How many eggs would you like?");
                s = Console.ReadLine();
                can_convert = int.TryParse(s, out n);
            } while (!can_convert);
            n = int.Parse(s);
            Console.WriteLine("Here are {0} eggs.  Have a nice day!", n);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
