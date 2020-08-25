using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //compile-time error: missing ";" also logic error because it needs to be in decimals
            decimal i = 0;
            //logic error: needed to be outside of the for loop to be used properly
            string allNumbers = null;

            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i)
            {
                // declare string to hold all numbers
                //logic error: needed to be outside of the for loop to be used properly
                //string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                //compile-time error: needed parenthesis
                if ((i - 1) != 0)
                {
                    Console.Write(i + "/" + (i - 1) + " = ");
                }

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1));
                //run-time error: dividing by zero

                if ((i-1) != 0)
                {
                    Console.WriteLine(i / (i - 1));
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //logic error: this is not needed as it already does this when the for loop was created
                //i = i + 1;
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            //compile-time error: missing concatenation
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
