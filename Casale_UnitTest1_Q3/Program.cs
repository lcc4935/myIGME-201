using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_UnitTest1_Q3
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Delegate Exercise
    //Restrictions: None
    class Program
    {
        delegate string MyReadLine();


        //Method: Main
        //Purpose: Questions 3 from Unit 1 Test, delegate for Console.ReadLine()
        //Output: none
        //Restrictions: None
        static void Main(string[] args)
        {
            MyReadLine myReadLine;

            myReadLine = new MyReadLine(Console.ReadLine);

            string myString = myReadLine();
        }
    }
}
