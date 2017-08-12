using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //this is our program entrypoint
        static void Main(string[] args)
        {
            //Step 1: Give the user an instruction
            Console.WriteLine("How many eggs would you like?");
            
            //Step 2: Read the user's input using the builtin function
            //Console.ReadLine()
            //This function takes input from the keyboard until the user presses the enter key
            string s = Console.ReadLine();

            //The Try block allows us to attempt a block of code without breaking our
            //Program if we see an exception
            try
            {
                int n = int.Parse(s);
                Console.WriteLine("Here are {0} eggs.  Have a nice day!", n);
            }  //This is the catch statement, which follows a try block
            catch (Exception e)
            {
                //We have to have a catch statement, the value in the parentheses tells
                //The program which type of exception to break on.
                //The Exception class here will catch *all* exceptions
                //We can make multiple catch blocks per try
                //And respond to different exceptions differently
                
                //Let the user know about the error
                Console.WriteLine("That's not a number");
            }
            
            //Wait for the user to catch a key.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
