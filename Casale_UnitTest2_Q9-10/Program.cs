using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Casale_UnitTest2_Q9_10
{
    //Lauren Casale Unit Test 2; Q 9-10


    //Abstract Class
    //Hockey
    public abstract class Hockey
    {
        public abstract void Play();
        public virtual void iceTime()
        {

        }
    }


    //Interface
    //ISkating
    public interface ISkating
    {
        void Skate();
    }


    //Class
    //Skating
    public class Skating: Hockey, ISkating
    {
        public override void Play()
        {

        }
        public void Skate()
        {
            Console.WriteLine("Skating");
        }
    }


    //Interface
    //IPuckHandling
    public interface IPuckHandling
    {
        void Puck();
    }


    //Class
    //PuckHandling
    public class PuckHandling: Hockey, IPuckHandling
    {
        public override void Play()
        {

        }
        public void Puck()
        {
            Console.WriteLine("Puck usage");
        }
    }


    //Class
    //Program
    class Program
    {
        static void Main(string[] args)
        {
            Skating skating = new Skating();
            PuckHandling puckHandling = new PuckHandling();

            MyMethod(skating);
            MyMethod(puckHandling);

        }

        public static void MyMethod(object obj)
        {

            IPuckHandling iPuckHandling;
            iPuckHandling = (IPuckHandling)obj;
            iPuckHandling.Puck();

            ISkating iSkating;
            iSkating = (ISkating)obj;
            iSkating.Skate();

        }


    }
}
