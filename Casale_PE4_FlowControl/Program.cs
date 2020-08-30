using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_PE4_FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            bool operand1;
            bool operand2;
            bool results;

            int var1 = 0;
            int var2 = 0;

            do
            {
                //recieve number as a string
                Console.WriteLine("Enter 2 numbers, both cannot be over 10");
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();

                try
                {
                    //convert string to int
                    var1 = Convert.ToInt32(s1);
                    var2 = Convert.ToInt32(s2);

                    //see if both, neither, or one but not the other, is over 10
                    operand1 = var1 < 10;
                    operand2 = var2 < 10;
                    results = (operand1 | operand2);
                }

                catch
                {
                    //both were over 10, so asking again
                    Console.WriteLine("Enter 2 numbers, both cannot be over 10");
                    results = false;
                }
            } while (!results);
        }
    }
}
