using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_UnitTest2_Q4_7
{
    //Lauren Casale Unit Test 2; Q 4-7

    //Abstract Class
    //Phone
    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber;
        public string address;

        public abstract void Connect();
        public abstract void Disconnect();
    }


    //Interface
    //PhoneInterface
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }


    //Class
    //RotaryPhone
    public class RotaryPhone: Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }


    //Class
    //PushButtonPhone
    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    //Class
    //Tardis

    public class Tardis: RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get
            {
                return whichDrWho;
            }
        }
        public string FemaleSideKick
        {
            get
            {
                return femaleSideKick;
            }
        }
        public void TimeTravel()
        {

        }

        public static bool operator < (Tardis dr1, Tardis dr2)
        {
            if (dr2.whichDrWho == 10)
            {
                return true;
            }
            if (dr1.whichDrWho == 10)
            {
                return false;
            }
            if (dr1.whichDrWho == dr2.whichDrWho)
            {
                return false;
            }
            
            return (dr1.whichDrWho < dr2.whichDrWho);
                
        }

        public static bool operator > (Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10)
            {
                return true;
            }
            if (dr2.whichDrWho == 10)
            {
                return false;
            }
            if (dr1.whichDrWho == dr2.whichDrWho)
            {
                return false;
            }

            return (dr1.whichDrWho > dr2.whichDrWho);
        }

        public static bool operator <= (Tardis dr1, Tardis dr2)
        {
            if (dr2.whichDrWho == 10)
            {
                return true;
            }
            if (dr1.whichDrWho == 10)
            {
                return false;
            }

            return (dr1.whichDrWho <= dr2.whichDrWho);
        }

        public static bool operator >= (Tardis dr1, Tardis dr2)
        {
            if (dr1.whichDrWho == 10)
            {
                return true;
            }
            if (dr2.whichDrWho == 10)
            {
                return false;
            }

            return (dr1.whichDrWho >= dr2.whichDrWho);
        }

        public static bool operator == (Tardis dr1, Tardis dr2)
        {
            return (dr1.whichDrWho == dr2.whichDrWho);
        }

        public static bool operator != (Tardis dr1, Tardis dr2)
        {
            return (dr1.whichDrWho != dr2.whichDrWho);
        }
    }


    //Class
    //PhoneBooth
    public class PhoneBooth: PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }
        public void CloseDoor()
        {

        }
    }



    //Class
    //Program
    class Program
    {
        static void Main(string[] args)
        {

            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);

        }

        static void UsePhone(object obj)
        {
            PhoneInterface phoneInterface;
            phoneInterface = (PhoneInterface)obj;
            phoneInterface.MakeCall();

            if (phoneInterface.GetType() == typeof(Tardis))
            {
                Tardis tardis;
                tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
            if (phoneInterface.GetType() == typeof(PhoneBooth))
            {
                PhoneBooth phoneBooth;
                phoneBooth = (PhoneBooth)obj;
                phoneBooth.OpenDoor();
            }
        }
    }

}