/***
 * This is a basic program.  Hello World.
 * This program does one thing: Prints the words "Hello World to the screen and exits"
 */

using System;  //This statement is an import.  this allows us to use code already provided by C#

/***
 * The namespace definition tells the complier where to find our code 
 * For now, all code we will write will be in the same namespace
 * We must also make sure that all of our lines of code are between the opening curly
 * brace { and the closing curly brace }
 * 
 * namespace is a keyword [it shows blue in visual studio] and HelloWorld is the name
 * we gave when we created the project
 * 
 * The code that follows this line [the {} and the code between them], is a block of code
 * This is refered to as the "namespace" block because it follows the namespace definition
 **/
namespace HelloWorld
{ //This opening curly brace gets matched by the complier to the correct one.
    /*
     * This is a class definition, we will talk about more later, but this is the default
     * class for the project.  Note that this definition, and everything in it is between the 
     * { and } of the namespace definition.  This means that the class is inside of the 
     * namespace HelloWorld
     */
    class Program
    {
        /***
         * This is a method or function definition.  This one is a bit special in that
         * it provides the entrypoint for our program.
         * 
         * If we break it down, we have 4 parts:
         * 1) The scope keyword [here it's "static"].  There can be more than one.  The valid
         * scopes are: public, private, internal, static, protected
         * 2) The next thing is the return value type [Here it's "void"]  There is only one, 
         * and it can be of a number of datatypes we will talk about later.  Or this can be the
         * special keyword "void" which means this returns no value.
         * 3) The next item is the Function name [Here it's "Main"] This can be any name you wish.
         * Since this function is special, it has to be named "Main"
         * 4) The Arguments list [Here it's (string[] args)]  The arguments show up inbetween the
         * parentheses.  We will look into this more later
         * 
         * */
        static void Main (string[] args)
        {
            /**
             * Here's where we actually do something!  This line of code is a function call.
             * We have two important parts:  The function name we're calling [Here 
             * it's "Console.WriteLine"], and then the arguments we're passing to the function
             **/
            Console.WriteLine ("Hello World");
            Console.ReadKey();
        }
    }
}
