using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace PetApp
{
    //Interface: ICat
    //Author: Lauren Casale
    //Purpose: Calling activities for cats
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();

    }

    //Class: Cat
    //Author: Lauren Casale
    //Purpose: Producing words for activities for cats
    public class Cat : Pet, ICat
    {
        public override void Eat()
        {
            Console.WriteLine(Name + "Food, food!");
        }

        public override void Play()
        {
            Console.WriteLine(Name + "I will catch that red dot this time, I swear!");
        }

        public void Purr()
        {
            Console.WriteLine(Name + "Yes, keep petting me! Purrrr");
        }

        public void Scratch()
        {
            Console.WriteLine(Name + "Stop what you're doing! Hiss");
        }

        public override void GotoVet()
        {
            Console.WriteLine(Name + "I hate the vet.");
        }

        public Cat(string name, int age) : base(name, age)//constructor
        {

        }
    }

    //Class: Pet
    //Author: Lauren Casale
    //Purpose: Calling common activites
    public abstract class Pet
    {
        private string name;
        public int age;
        public string Name;

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

        public Pet(string name, int age) // constructor
        {
            this.name = name;
            this.age = age;
        }


    }

    //Class: Pets
    //Author: Lauren Casale
    //Purpose: Works with the list of all pets
    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        //Method: Count
        //Author: Lauren Casale
        //Purpose: Counts through list
        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        //Method: Add
        //Author: Lauren Casale
        //Purpose: Adds a pet to the pet list
        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        //Method: Remove
        //Author: Lauren Casale
        //Purpose: Removes a pet from the pet list
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        //Method: RemoveAt
        //Author: Lauren Casale
        //Purpose: Works with removing in the petEl
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }

    }

    //Interface: IDog
    //Author: Lauren Casale
    //Purpose: Calling activities for dogs
    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    //Class: Dog
    //Author: Lauren Casale
    //Purpose: Procuding words for activites for dogs
    public class Dog : Pet, IDog
    {
        public string license;

        public override void Eat()
        {
            Console.WriteLine(Name + "Food, food!");
        }

        public override void Play()
        {
            Console.WriteLine(Name + "Play time! Frisbee?");
        }

        public void Bark()
        {
            Console.WriteLine(Name + "Woof!");
        }

        public void NeedWalk()
        {
            Console.WriteLine(Name + "Outside please, get the leash!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(Name + "But I don't like it there.");
        }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge) //constructor
        {
            this.license = szLicense;
        }
    }

    //Class: Program
    //Author: Lauren Casale
    //Purpose: Console Read/Write Exercise
    class Program
    {

        //Method: Main
        //Purpose: Getting pets to the list and then calling the activites
        //Output: Pet names and activities
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();

            int i = 0;
            for (i = 0; i < 50; i++)
            {
            start:
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    // 50% chance of adding a dog
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");

                        Console.WriteLine("What do you want to name your dog?");
                        thisPet.Name = Console.ReadLine();
                        Console.WriteLine("How old do you want your dog to be?");
                        string a = Console.ReadLine();
                        thisPet.age = Convert.ToInt32(a);
                        Console.WriteLine("What is your dog's license number?");
                        dog.license = Console.ReadLine();

                        thisPet = new Dog(dog.license, thisPet.Name, thisPet.age);
                    }
                    else
                    {
                        // else add a cat
                        Console.WriteLine("You bought a cat!");

                        Console.WriteLine("What do you want to name your cat?");
                        thisPet.Name = Console.ReadLine();
                        Console.WriteLine("How old do you want your cat to be?");
                        string a = Console.ReadLine();
                        thisPet.age = Convert.ToInt32(a);

                        thisPet = new Cat(thisPet.Name, thisPet.age);

                    }

                }
                else
                {
                    int num = rand.Next(0, pets.Count);
                    thisPet = Pets.petList(num); //I didn't know how to iterate throuh a list
                    if (thisPet == null)
                    {
                        goto start;
                    }
                    else
                    {
                        if (thisPet.GetType() = (Pet)iDog) // I didn't know how to use .GetType
                        {
                            thisPet = (Pet)iDog;

                            //picking an activity
                            int r = rand.Next(0, 4);
                            if (r == 0)
                            {
                                dog.Eat();
                            }
                            else if (r == 1)
                            {
                                dog.Play();
                            }
                            else if (r == 2)
                            {
                                dog.Bark();
                            }
                            else if (r == 3)
                            {
                                dog.NeedWalk();
                            }
                            else
                            {
                                dog.GotoVet();
                            }

                        }
                        else
                        {
                            thisPet = (Pet)iCat;

                            //picking an activity
                            int r = rand.Next(0, 4);
                            if (r == 0)
                            {
                                cat.Eat();
                            }
                            else if (r == 1)
                            {
                                cat.Play();
                            }
                            else if (r == 2)
                            {
                                cat.Purr();
                            }
                            else if (r == 3)
                            {
                                cat.Scratch();
                            }
                            else
                            {
                                cat.GotoVet();
                            }
                        }
                    }
                }
            }
        }
    }
}