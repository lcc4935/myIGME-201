using System;

namespace UT1_BugSquash
{
    // Class Program
    // Author: David Schuh - edited by Lauren Casale
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Calculate x^y for y > 0 using a recursive function
        // Restrictions: None
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY
            //compile-error
            //needs a semicolon at the end
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);
            //compile-time error
            //needs quotation marks
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.Readline
                sNumber = Console.ReadLine();
                //logic error
                //needed to set sNumber equal to Console.ReadLine()
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            //} while (int.TryParse(sNumber, out nX));
            //logic error
            //wrote nX instead of nY and didn't add the "!" which it needs to make sure it is a number
            } while (!int.TryParse(sNumber, out nY));

            // compute the factorial of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }

        //int Power(int nBase, int nExponent)
        //compile-time error
        //needed to add static
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal;
            //compile-time error
            //needed to add the command return

            return returnVal;
        }
    }
}
