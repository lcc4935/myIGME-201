using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Casale_UnitTest1_Q13
{

    struct employee
    {
        public string sName;
        public double dSalary;
    }

    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Question 13 on Unit 1 Test; using structs
        //Output: Their salary increases if their name is Lauren
        //Restrictions: None
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");

            employee[] raise = new employee[1];
            raise[0].sName = Console.ReadLine();
            raise[0].dSalary = 30000;

            if (GiveRaise(raise) == true)
            {
                Console.WriteLine("Congrats, you got a raise!\nYour salary is now " + raise[0].dSalary + "!");
            }

        }

        static bool GiveRaise(employee[] raise)
        {
            if (raise[0].sName == "Lauren")
            {
                raise[0].dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
