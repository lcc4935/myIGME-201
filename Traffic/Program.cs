using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Object;
using Vehicles;

namespace Traffic
{
    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write exercise
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Question 6 in exercise
        //Output: None
        //Restrictions: None
        static void Main(string[] args)
        {
            
        }

        //Method: AddPassenger
        //Purpose: retrieve from Vehicle library
        //Output: object from LoadPassenger from IPassengerCarrier
        //Restrictions: None
        static void AddPassenger(IPassengerCarrier obj)
        {
            object value = obj.LoadPassenger();
            Console.WriteLine(value.ToString());
        }

    }
}