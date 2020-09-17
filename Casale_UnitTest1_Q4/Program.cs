using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Casale_UnitTest1_Q4
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        static bool bTimeOut = false;

        static Timer timeOutTimer;


        //Method: Main
        //Purpose: Question 4 on Unit Test, Timer on 3 questions
        //Output: correct answer if wrong or a well done comment if correct
        //Restrictions: None
        static void Main(string[] args)
        {
            //variables
            string answer = null;

            //start
            start:
            Console.WriteLine("Choose your question (1-3)");
            string question = Console.ReadLine();

            //question 1
            if (question == "1")
            {
                bTimeOut = false;
                Console.WriteLine("You have 5 seconds to answer the following question:");
                while(!bTimeOut)
                {
                    Console.WriteLine("What is your favorite color?");

                    timeOutTimer = new Timer(5000);
                    timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);
                    timeOutTimer.Start();

                    answer = Console.ReadLine();

                    timeOutTimer.Stop();

                    //if correct
                    if (answer == "black" && !bTimeOut)
                    {
                        Console.WriteLine("Well done!");
                        bTimeOut = true;
                    }
                    //if incorrect
                    else if (!bTimeOut)
                    {
                        Console.WriteLine("Wrong! The answer is: black");
                        bTimeOut = true;
                    }
                    else
                    {
                        //if time ran out
                        Console.WriteLine("The answer is: black");
                    }

                }
                
            }
            //question 2
            else if (question == "2")
            {
                bTimeOut = false;
                Console.WriteLine("You have 5 seconds to answer the following question:");
                while (!bTimeOut)
                {
                    Console.WriteLine("What is the answer to life, the universe and everything?");

                    timeOutTimer = new Timer(5000);
                    timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);
                    timeOutTimer.Start();

                    answer = Console.ReadLine();

                    timeOutTimer.Stop();

                    //if correct
                    if (answer == "42")
                    {
                        Console.WriteLine("Well done!");
                        bTimeOut = true;
                    }
                    //if incorrect
                    else if (!bTimeOut)
                    {
                        Console.WriteLine("Wrong! The answer is: 42");
                        bTimeOut = true;
                    }
                    else
                    {
                        //if time ran out
                        Console.WriteLine("The answer is: 42");
                    }
                }

            }
            //question 3
            else if (question == "3")
            {
                bTimeOut = false;
                Console.WriteLine("You have 5 seconds to answer the following question:");
                while (!bTimeOut)
                {
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");

                    timeOutTimer = new Timer(5000);
                    timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);
                    timeOutTimer.Start();

                    answer = Console.ReadLine();

                    timeOutTimer.Stop();

                    //if correct
                    if (answer == "What do you mean? African or European swallow?")
                    {
                        Console.WriteLine("Well done!");
                        bTimeOut = true;
                    }
                    //if incorrect
                    else if (!bTimeOut)
                    {
                        Console.WriteLine("Wrong! The answer is: What do you mean? African or European swallow?");
                        bTimeOut = true;
                    }
                    else
                    {
                        //if time ran out
                        Console.WriteLine("The answer is: What do you mean? African or European swallow?");
                    }
                }

            }
            //didn't put a valid number for a question
            else
            {
                goto start;
            }

            Ask:
                Console.WriteLine("Would you like to play again?");
                string yesNo = Console.ReadLine();
                yesNo = yesNo.ToLower();
                if (yesNo == "yes")
                {
                    goto start;
                }
                else if(yesNo != "no")
                {
                    goto Ask;
                }
        }

        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Your time is up!");
            Console.WriteLine("Please Press Enter");

            bTimeOut = true;
            timeOutTimer.Stop();
        }
    }
}
