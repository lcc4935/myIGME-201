using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casale_PE7_MadLibs
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    //Method: Main
    //Purpose: Creating a Mad Libs with user input
    //Output: The finished Mad Libs with the user inputs
    //Restrictions: None

    {
        static void Main(string[] args)
        {
            //asking to play game
            Console.WriteLine("Do you want to play Mad Libs?");
            string answer = "";

            while(answer.ToLower() != "yes" && answer.ToLower() != "no")
            {
                answer = Console.ReadLine();
            }

            if (answer.ToLower() == "no")
            {
                Console.WriteLine("Goodbye");
                //closes if no
                System.Environment.Exit(0);

            }

            //variables
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            string finalML = null;

            //Mad Libs into array of strings
            StreamReader input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
            string line = null;
            while((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }
            input.Close();

            string[] madLibs = new string[numLibs];

            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            while((line = input.ReadLine()) != null)
            {
                madLibs[cntr] = line;

                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            //asks user fo which game
            Console.WriteLine("Which Mad Lib do you want to do? (1-" + numLibs + ")");

            nChoice = Convert.ToInt32(Console.ReadLine());

            //splitting into words
            string[] words = madLibs[nChoice].Split(' ');

            //goes through and has user fill in their words
            foreach(string thisWord in words)
            {
                if (thisWord.StartsWith("{"))
                {
                    Console.WriteLine("Enter a" + thisWord.Replace('{', ' ').Replace('}', '!').Replace('_', ' '));
                    string uInput = Console.ReadLine();
                    finalML += uInput + " ";
                }
                else
                {
                    finalML += thisWord + " ";
                }
            }
            Console.Write(finalML);
            Console.ReadKey();

        }
    }
}
