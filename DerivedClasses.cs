using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
   public class MachineGunner : StormTrooper  , ITest//Example of Inheritance
    {
        //public new string name; Not needed because of inheritance
        //public new int age;
        public MachineGunner(string abasicName, string aName, int aAge, string aAlienSpecies, int aHeight) : base(abasicName, aName, aAge, aAlienSpecies, aHeight) //Self-Explanatory
        {
        }
        public void Rambo()
        {
            Console.WriteLine("\n\tDude, I feel so operator!");
        }  
        public void Truth()
        {
            Console.WriteLine("\n\tMachine guns are alot heavier in real life");
        }
        public void Deconstruct(out string aName, out int aAge)
        {
            aName = name;
            aAge = age;
        }
    }
    public class Sniper : StormTrooper, ITest  //Example of Inheritance
    {
        public Sniper(string abasicName, string aName, int aAge, string aAlienSpecies, int aHeight) : base(abasicName, aName, aAge, aAlienSpecies, aHeight)
        {
        }
        public void Sneaky()
        {
            Console.WriteLine("\n\tI'm the hide'n seek champion!");
        }
        public void Champ()
        {
            Console.WriteLine("\n\tYou can't see me.");
        }
        public void Deconstruct(out string aName, out int aAge)
        {
            aName = name;
            aAge = age;
        }
    }
    public class Pilot : StormTrooper, ITest  //Example of Inheritance
    {
        public Pilot(string abasicName, string aName, int aAge, string aAlienSpecies, int aHeight) : base(abasicName, aName, aAge, aAlienSpecies, aHeight)
        {
        }
        public void TopGun()
        {
            Console.WriteLine("\n\tI feel the need...the need for speed");
        }
        public void Flyer() 
        {
            Console.WriteLine("\n\tWe don't let new guys fly so soon");
        }
        public void Deconstruct(out string aName, out int aAge)
        {
            aName = name;
            aAge = age;
        }
    }
    public class Engineer : StormTrooper, ITest  //Example of Inheritance
    {
        public Engineer(string abasicName, string aName, int aAge, string aAlienSpecies, int aHeight) : base(abasicName, aName, aAge, aAlienSpecies, aHeight)
        {
        }
        public void Builder()
        {
            Console.WriteLine("\n\tCan we fix it? Yes, we can!");
        }
        public void BuildStuff()
        {
            Console.WriteLine("\n\tLet's buils some stuff.");
        }
        public void Deconstruct(out string aName, out int aAge)
        {
            aName = name;
            aAge = age;
        }
    }
     public class JediPadawan : Jedi  //Example of Inheritance
    {
        public JediPadawan (string aName, int aAge, string aAlienSpecies, int aHeight) : base(aName, aAge, aAlienSpecies, aHeight)
        {

        }
        public void Student()
        {
            Console.WriteLine("\n\tHow do I do this again?");
        }
        public void Deconstruct(out string aName, out int aAge)
        {
            aName = name;
            aAge = age;
        }
    }
     public class JediKnight : Jedi, ITest  //Example of Inheritance
    {      
        public JediKnight(string aName, int aAge, string aAlienSpecies, int aHeight) : base(aName, aAge, aAlienSpecies, aHeight)
        {           
        }
        public void Intro()
        {
            Console.WriteLine($"\n\tGreetings I'm {name}");            
        }      
        public void Deconstruct(out string aName, out int aAge)
        {
            aName = name;
            aAge = age;
        }
    }
    public class JediMaster : Jedi  //Example of Inheritance
    {
        public JediMaster(string aName, int aAge, string aAlienSpecies, int aHeight) : base(aName, aAge, aAlienSpecies, aHeight)
        {
        }
        public void Master()
        {
            Console.WriteLine("\n\tThat's not how you do that!");
        }
        public void Deconstruct(out string aName, out int aAge)
        {
            aName = name;
            aAge = age;
        }    
    }
     sealed class Lightsaber : Weapon  //Example of Inheritance, no one should inherit from Lightsaber
    {
        public int bladeNum; //derived specific field
        public Lightsaber(int aBladeNum, string aName, string aSound, int aSize, string aColor) : base(aName, aSound, aSize, aColor)
        {
            bladeNum = aBladeNum;
        }
        public void Deconstruct(out string aColor, out string aName, out string aSound)
        {
            aColor = color;
            aName = name;
            aSound = sound;
        }
        public void SaberColor()
        {
            Console.WriteLine("\n\tWhat color lighsaber do you want?");         
        }
        public string RedSaber()
        {
            Console.WriteLine("\n\tCongrats on the red Saber!");
            return "some"; //Not intended to display
        }
        public string OrangeSaber()
        {
            Console.WriteLine("\n\tCongrats on the orange saber!");
            return "some";
        }
        public string YellowSaber()
        {
            Console.WriteLine("\n\tCongrats on the yellow saber!");
            return "some";
        }
        public string GreenSaber()
        {
            Console.WriteLine("\n\tCongrats on the green saber");
            return "some";
        }
        public string BlueSaber()
        {
            Console.WriteLine("\n\tCongrats on the blue saber!");
            return "some";
        }
        public string Indigo()
        {
            Console.WriteLine("\n\tCongrats on the indigo saber!");
            return "some";
        }
        public string VioletSaber()
        {
            Console.WriteLine("\n\tCongrats on the violet saber!");
            return "some";
        }
        public string WhiteSaber()
        {
            Console.WriteLine("\n\tCongrats on the white saber!");
            return "some";
        }
    }
    class Blaster : Weapon  //Example of Inheritance
    {
        public Blaster(string aName, string aSound, int aSize, string aColor) : base(aName, aSound, aSize, aColor)
        {
        }
        public void Clean()
        {
            Console.WriteLine("\n\tIt's time to do my monthly blaster cleaning.");
        }
        public void Deconstruct(out string aName, out string aSound)
        {
            aName = name;
            aSound = sound;
        }
    }
    sealed class ThermalDetonator : Weapon  //No class can inherit from a sealed class
    {
        public ThermalDetonator(string aName, string aSound, int aSize, string aColor) : base(aName, aSound, aSize,aColor)
        {
        }
        public void Range()
        {
            Console.WriteLine("\n\tThe grenade range is tommorow.");
        }
        public void Deconstruct(out string aName, out string aSound)
        {
            aName = name;
            aSound = sound;
        }
    }
    class StarShip : Vehicle  //Example of Inheritance
    {       
        public StarShip(string aName, string aSound, int aSize, string aColor) : base(aName, aSound, aSize, aColor)
        {
           
        }
        public override void Operate() // Polymorphism!
        {
            Console.WriteLine("\n\tI'm flying the ship");
        }

        public void Deconstruct(out string aName, out string aSound)
        {
            aName = name;
            aSound = sound;
        }
    }
    class Tank : Vehicle  //Example of Inheritance
    {
        public Tank(string aName, string aSound, int aSize, string aColor) : base(aName, aSound, aSize, aColor)
        {
        }
        public override void Operate() // Polymorphism!
        {
            Console.WriteLine("\n\tI better not park this tank in the fire lane!");
        }
        public void Deconstruct(out string aName, out string aSound)
        {
            aName = name;
            aSound = sound;
        }
    }
      sealed class ATAT : Vehicle  //Example of Inheritance
    {
        public ATAT(string aName, string aSound, int aSize, string aColor) : base(aName, aSound, aSize, aColor)
        {
        }
        public override void Operate() // Polymorphism!
        {
            Console.WriteLine("\n\tWhy do AT-ATs, not have wi-fi?");
        }
        public void Deconstruct(out string aName, out string aSound)
        {
            aName = name;
            aSound = sound;
        }
    }
}
