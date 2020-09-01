using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_PE6_ParsingAndFormatting
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: User has 8 turns to guess a random number between 0 and 100
        //Output: Too high, too low, correct number, ran out of turns
        //Restrictions: None
        static void Main(string[] args)
        {
            //variables
            int i = 1;
            int guess = 101;

            //random number generator
            Random rand = new Random();
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine(randomNumber);

            //Letting them know the boundry
            Console.WriteLine("Guesses must be between 0 and 100");

            while(i < 9)
            {
                //asking for guess
                Console.Write("Turn #" + i + ": Enter your guess: ");
                string s1 = Console.ReadLine();
                guess = int.Parse(s1);

                //making sure guess is in range
                while ((0 > guess) | (guess > 100))
                {
                    Console.Write("Invalid guess, enter your guess: ");
                    s1 = Console.ReadLine();
                    guess = int.Parse(s1);
                }

                //telling too high, too low, or guessed it
                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low");
                } else
                if (guess > randomNumber)
                {
                    Console.WriteLine("Too High");
                } else
                if (guess == randomNumber)
                {
                    if (i == 1)
                    {
                        //getting rid og the plural in "turns" if it was only one guess
                        Console.WriteLine("Correct! You guessed the correct number in " + i + " turn!");
                    } else
                    {
                        Console.WriteLine("Correct! You guessed the correct number in " + i + " turns!");
                    }
                    //ending the while loop without getting the ran out of turns message
                    i = 10;
                }
                //adding to counter
                i = i + 1;

            }
            //ran out of turns message
            if (i == 9)
            {
                Console.WriteLine("Sorry you ran out of turns. The number was " + randomNumber + ".");
            }
        }
    }
}
