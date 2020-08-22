using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num1 = 3;
            int num2 = 4;
            int i = 0;

            string stringNum = "12";

            //math
            int number = num1 * num2;

            //loop
            for (i = 0; i < number; ++i)
            {
                Console.WriteLine("Hello World!");
            }

            //writing
            Console.WriteLine("My name is Lauren Casale.");
            Console.WriteLine($"My favorite number is {number + "."}");

        }
    }
}
