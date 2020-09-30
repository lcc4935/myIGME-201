using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casale_PE14_Classy
{
    //Interface: IPizza
    //Author: Lauren Casale
    //Purpose: Calling eat activity
    public interface IPizza
    {
        void Eat();
    }

    //Class: Cheese
    //Author: Lauren Casale
    //Purpose: Producing words for eat activity for cheese
    public class Cheese : IPizza
    {
        public void Eat()
        {
            Console.WriteLine("I like cheese pizza");
        }

    }

    //Class: Pepperoni
    //Author: Lauren Casale
    //Purpose: Producing words for eat activity for pepperoni
    public class Pepperoni : IPizza
    {
        public void Eat()
        {
            Console.WriteLine("I like pepperoni pizza");
        }

    }

    //Class: Program
    //Author: Lauren Casale
    //Purpose: Making objects and referencing other classes and interfaces
    class Program
    {
        //Method: Main
        //Purpose: Making objects
        static void Main(string[] args)
        {
            Cheese cheese = null;
            Pepperoni pepperoni = null;

            cheese = new Cheese();
            pepperoni = new Pepperoni();

            MyMethod(cheese);
            MyMethod(pepperoni);

        }

        //Method: MyMethod
        //Purpose: Calling interface through objects
        public static void MyMethod(object myObject)
        {
            IPizza iPizza;
            
            iPizza = (IPizza)myObject;

            iPizza.Eat();

        }
    }
}