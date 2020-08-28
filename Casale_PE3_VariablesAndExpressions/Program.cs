using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_PE3_VariablesAndExpressions
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Asking user for a number and returning the product
        //Output: Product of the numbers
        //Restrictions: None
        static void Main(string[] args)
        {
            //Boolean variables
            bool bValid1 = false;
            bool bValid2 = false;
            bool bValid3  = false;
            bool bValid4 = false;

            //number variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;


            //Number 1
            do
            {
                //recieve number as a string
                Console.WriteLine("Type a number please");
                string s1 = Console.ReadLine();

                try
                {
                    //convert string to int
                    num1 = Convert.ToInt32(s1);
                    bValid1 = true;
                }

                catch
                {
                    //didn't work, so asking again for a number
                    Console.WriteLine("Please enter a number.");
                    bValid1 = false;
                }
            } while (!bValid1);

            //Number 2
            do
            {
                //recieve number as a string, round 2
                Console.WriteLine("Another number");
                string s2 = Console.ReadLine();

                try
                {
                    //convert string to int, round 2
                    num2 = Convert.ToInt32(s2);
                    bValid2 = true;
                }

                catch
                {
                    //didn't work, so asking again for a number, round 2
                    Console.WriteLine("Please enter a number.");
                    bValid2 = false;
                }
            } while (!bValid2);

            //Number 3
            do
            {
                //recieve number as a string, round 3
                Console.WriteLine("Last one");
                string s3 = Console.ReadLine();

                try
                {
                    //convert string to int, round 3
                    num3 = Convert.ToInt32(s3);
                    bValid3 = true;
                }

                catch
                {
                    //didn't work, so asking again for a number, round 3
                    Console.WriteLine("Please enter a number.");
                    bValid3 = false;
                }
            } while (!bValid3);

            //Number 4
            do
            {
                //recieve number as a string, round 4
                Console.WriteLine("I lied, this is the last one");
                string s4 = Console.ReadLine();

                try
                {
                    //convert string to int, round 4
                    num4 = Convert.ToInt32(s4);
                    bValid4 = true;
                }

                catch
                {
                    //didn't work, so asking again for a number, round 4
                    Console.WriteLine("Please enter a number.");
                    bValid4 = false;
                }
            } while (!bValid4);
            
            //getting the product
            int number = num1 * num2 * num3 * num4;
            Console.WriteLine("And the sum is " + number);



        }
    }
}
