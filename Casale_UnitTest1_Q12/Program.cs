using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Casale_UnitTest1_Q12
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Question 12 on Unit 1 Test; using bool functions
        //Output: Their salary increase if their name is Lauren
        //Restrictions: None
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("What is your name?");
            sName = Console.ReadLine();

            if(GiveRaise(sName, ref dSalary) == true)
            {
                Console.WriteLine("Congrats, you got a raise!\nYour salary is now " + dSalary + "!");
            }

        }

        static bool GiveRaise(string name, ref double salary)
        {
            if (name == "Lauren")
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
