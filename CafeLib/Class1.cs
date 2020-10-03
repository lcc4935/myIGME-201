using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    //abstract classes:

    //Class: HotDrink
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public virtual void AddSugar(byte smount)
        {

        }
        public abstract void Steam();
        public HotDrink()
        {

        }
        public HotDrink(string brand)
        {

        }
    }

    //Interfaces

    //Interface: IMood
    public interface IMood
    {
        string Mood
        {
            get;
        }
    }

    //Interface: ITakeOrder
    public interface ITakeOrder
    {
        void TakeOrder();
    }

    //classes

    //Waiter
    public class Waiter: IMood
    {
        public string name;

        public string Mood
        {
            get;
        }

        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    //Customer
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get;
        }
    }

    //CupOfCoffee
    public class CupOfCoffee: HotDrink, ITakeOrder
    {
        public string beanType;

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        public CupOfCoffee(string brand) : base(brand)
        {

        }
    }

    //CupOfTea
    public class CupOfTea: HotDrink, ITakeOrder
    {
        public string leafType;

        public override void Steam()
        {
           
        }

        public void TakeOrder()
        {

        }
        public CupOfTea(bool customerIsWealthy)
        {

        }
    }

    //CupOfCocoa
    public class CupOfCocoa: HotDrink, ITakeOrder
    {
        public static int numCup;
        public bool marshmallows;
        private string source;

        public string Source
        {
            set
            {
                this.source = value;
            }
        }

        public override void Steam()
        {

        }

        public override void AddSugar(byte amount)
        {
            
        }

        public void TakeOrder()
        {

        }

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {
            // I don't know where to add this: ():this(false) and I don't know exactly how to write it
        }

        public CupOfCocoa() : this(false)
        {

        }
    }

}
