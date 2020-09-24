using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casale_PE12_DefiningClassMembers
{
    public class MyClass
    {
        private string myString;
        public string MyString
        {
            set
            {
            }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }

    public class MyDerivedClass: MyClass
    {
        public override string GetString()
        {
            return base.GetString() + "output from the derived class";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass myDClass = new MyDerivedClass();
            string sString = myDClass.GetString();
        }
    }
}
