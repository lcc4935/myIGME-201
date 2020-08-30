using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;


            //what I added
            //imagCoord numbers
            double var1, var2;
            bool results;
            do
            {
                //recieve number as a string
                Console.WriteLine("Enter 2 numbers, first one larger than the second");
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();

                try
                {
                    //convert string to double
                    var1 = Convert.ToDouble(s1);
                    var2 = Convert.ToDouble(s2);

                    //see if first is larger than the second
                    results = var1 > var2;
                    double mult = (var1 + var2) / 48;
                }

                catch
                {
                    //didn't follow rule
                    Console.WriteLine("Enter 2 numbers, first one larger than the second");
                    results = false;
                }
            } while (!results);

            for (imagCoord = var1; imagCoord >= var2; imagCoord -= mult)
            {
                //realCoord numbers
                double var1a, var2a;
                bool resultsa;
                do
                {
                    //recieve number as a string
                    Console.WriteLine("Enter 2 numbers, first one lower than the second");
                    string s1a = Console.ReadLine();
                    string s2a = Console.ReadLine();

                    try
                    {
                        //convert string to double
                        var1a = Convert.ToDouble(s1a);
                        var2a = Convert.ToDouble(s2a);

                        //see if first is lower than the second
                        resultsa = var1a < var2a;
                        double multa = (var1a + var2a) / 80;
                    }

                    catch
                    {
                        //didn't follow rule
                        Console.WriteLine("Enter 2 numbers, first one lower than the second");
                        resultsa = false;
                    }
                } while (!resultsa);

                for (realCoord = var1a; realCoord <= var2a; realCoord += multa)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
