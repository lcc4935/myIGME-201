using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_PE8_MoreAboutVariables
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Questions 5, 7, 8, 9 from the exercise
        //Output: Q5: none, Q7: reversed string, Q8: the replaced string, Q9: none
        //Restrictions: None
        static void Main(string[] args)
        {

            //Question 5:
            Console.WriteLine("Question 5");
            //put x, y, and z into a 3-D aray

            double x = -1;
            double y = 1;
            double z = 0;
            double cntr = 0;
            double[,,] math = new double[20, 30, 600];
            //z = 3y^2 + 2x - 1
            for (x = -1; x <= 1; x = x + .1)
            {
                for (y = 1; y <= 4; y = y + .1)
                {
                    z = 3 * (Math.Pow(y, 2)) + 2 * x - 1;

                    //math[cntr, 0, 0] = x;
                    //math[cntr, 1, 1] = y;
                    //math[cntr, 2, 2] = z;

                    cntr = cntr + .1;
                }
            }



            //Question 7:
            Console.WriteLine("Question 7");
            //reverse the characters of what the user enters

            Console.WriteLine("Enter some words.");
            string reverse = Console.ReadLine();

            char[] characters = reverse.ToCharArray();
            Array.Reverse(characters);
            Console.WriteLine(characters);



            //Question 8:
            Console.WriteLine("Question 9");
            //turn "no" into "yes"

            Console.WriteLine("Enter some words that includes 'no'");
            string no = Console.ReadLine();
            string nowYes = null;

            nowYes = no.Replace("no", "yes");
            Console.WriteLine(nowYes);




            //Question 9:
            Console.WriteLine("Question 9");
            //adds double quotes around every word of a sentence the user enters
            Console.WriteLine("Enter a sentence");

            string sentence = Console.ReadLine();
            //string quotedWords = null;

            char[] quotedWords = { ' ' };

            for (int o = 0; o < quotedWords.Length; o++)
            {
                //quotedWords[o] = quotedWords[o].PadLeft(quotedWords[o].Length, '"')
                //quotedWords[o] = quotedWords[o].PadRight(quotedWords[o].Length, '"')
            }

            Console.WriteLine(quotedWords);

        }

    }
}