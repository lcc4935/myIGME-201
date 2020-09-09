using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_PE9_Functions_part2
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        delegate string response(string respond);


        //Method: Main
        //Purpose: Questions 3 from the exercise; delegates
        //Output: what the user typed
        //Restrictions: None
        static void Main(string[] args)
        {
            Console.WriteLine("Write something");

            string responseAnswer = null;

            // declare the delegate variable which will point to the function to be called
            response answerQuestion;

            // based on the operation
            // set the delegate function variable to the Divide() function
            answerQuestion = new response(recievedAnswer);

            // call the delegate function to compute the answer
            string answer = answerQuestion(responseAnswer);

            // output the answer using the ternary operator to display the math operation
            Console.WriteLine(answer);
        }
        static string recievedAnswer(string respond)
        {
            return Console.ReadLine();
        }
    }
}