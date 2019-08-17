using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
     public class StormTrooper : ITest
    {
        public string basicName;
        public string name;
        public string alienSpecies;
        public int height;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int age;
        public StormTrooper()
        {

        }
        public StormTrooper(string abasicName, string aName, int aAge, string aAlienSpecies, int aHeight)
        {
            basicName = abasicName;
            name = aName;
            age = aAge;
            alienSpecies = aAlienSpecies;
            height = aHeight;
        }
        public void BadLuck()
        {
            Console.WriteLine("\n\tWelcome to tatooine!\n\t We have 2 suns here!");
        }
        public void NameYourself() 
        {
            Console.WriteLine("\n\tWhat's your name?");
        }
        public void Lost()
        {
            Console.WriteLine("\n\tI have no clue where I'm at!");
        }
        public void Reload()
        {
            Console.WriteLine("\n\tPass me more ammo.");
        }
        public void Train()
        {
            Console.WriteLine("\n\tLets start your training");
        }
        public void Job()
        {
            Console.WriteLine("\n\tChoose from the following jobs:\n\t");
            Console.WriteLine("\n\tMachinegunner\n\tSniper\n\tPilot\n\tEngineer");
            Console.WriteLine("\n\tMaybe you'll get lucky...");
        }
    }
    public class Jedi : ITest
    {    
        public string name;
        public int age;
        public string alienSpecies;
        public int height;
 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Jedi(string aName, int aAge, string aAlienSpecies, int aHeight)
        {          
            name = aName;
            age = aAge;
            alienSpecies = aAlienSpecies;
            height = aHeight;
        }
        public void NameYourself()
        {
            Console.WriteLine("\n\tWhat's your name?");
        }
        public void Bamboozle()
        {
            Console.WriteLine("\n\tThese are not the droids you're looking for");
        }
       public void Post()
        {
            Console.WriteLine("\n\tYou have duty today!");
        }     
    }
    abstract class Weapon //No one can instaniate an object of weapon now
    {
        public string name;
        public string sound;
        public int size;
        public string color;

       public Weapon(string aName, string aSound, int aSize, string aColor)
        {
            name = aName;
            sound = aSound;
            size = aSize;
            color = aColor;
        }
        public void Pass()
        {
            Console.WriteLine("\n\tPass me that weapon!");
        }
    }
    class Vehicle
    {
        public string name;
        public string sound;
        public int size;
        public string color;

        public Vehicle(string aName, string aSound, int aSize, string aColor)
        {
            name = aName;
            sound = aSound;
            size = aSize;
            color = aColor;
        }
        public virtual void Operate()
        {
            Console.WriteLine("\n\tIt's my turn to drive");
        }
    }
}
