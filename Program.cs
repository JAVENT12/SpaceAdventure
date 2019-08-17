using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MilitaryUnit
{
    public class Program
    {
        public static string destiny()
        {
            Console.WriteLine("\n\tWould you wan't to be a Jedi or Stormtrooper?");
            string choice = Console.ReadLine().ToLower();
           
                if (choice == "jedi") JediPath();
                if (choice == "stormtrooper") stormTroopPath();
                if (choice == "no") throw new ArgumentException ("User not interested");
                return destiny();
        }
        public static string JediPath()
        {
            Jedi chosen1 = new Jedi(aName: Console.ReadLine(), 18, "Human", 70);
            Jedi Master = new JediMaster(aName:"Bixby", 22, "Utapuan", 94);
            Master.NameYourself();
            string aName = Console.ReadLine();
            string nombre = aName;
            if ((aName == " ") || (aName == "")) return JediPath();
            Console.WriteLine($"\n\tWelcome to the alliance {aName}!");
            Console.WriteLine($"\n\tWhat color lightsaber do you want {aName}?\n\tRed\n\tOrange\n\tYellow\n\tGreen\n\tBlue\n\tIndigo\n\tViolet\n\tWhite");
            string choice = Console.ReadLine().ToLower();
            if ((choice == "") || (choice == " ")) return JediPath();
            Random r = new Random(); //random variable
            var list = new List<string> { "red", "orange", "yellow", "green", "blue", "indigo", "violet"," white" };
            int color = r.Next(list.Count); // Random index
            string lucky = (list[color]); // String of random index
            Lightsaber mystery = new Lightsaber(1, "slicer" ,"Whoosh",4, lucky);
            Console.WriteLine($"\n\tLooks like you got {lucky}!"); // Maybe you got lucky??
            if (choice == lucky)
            {
                if (choice == "red") return mystery.RedSaber() + jediTrainPath(chosen1, nombre); 
                if (choice == "orange") return mystery.OrangeSaber() + jediTrainPath(chosen1, nombre); 
                if (choice == "yellow") return mystery.YellowSaber() + jediTrainPath(chosen1, nombre); 
                if (choice == "green") return mystery.GreenSaber() + jediTrainPath(chosen1, nombre); 
                if (choice == "blue") return mystery.BlueSaber() + jediTrainPath(chosen1, nombre);
                if (choice == "indigo") return mystery.Indigo() + jediTrainPath(chosen1, nombre);
                if (choice == "violet") return mystery.VioletSaber() + jediTrainPath(chosen1, nombre);
                if (choice == "white") return mystery.VioletSaber() + jediTrainPath(chosen1, nombre);
            }
            else if (choice != lucky) return DutyPath(chosen1, nombre);
            return "The Force"; //Not meant to display
        }
        public static string DutyPath(Jedi chosen1, string nombre)
        {
            chosen1.Post();
            Console.WriteLine($"\n\t{nombre} is going to have a lot of fun...");
            return "The force";
        }
        public static string jediTrainPath(Jedi chosen1, string nombre)
        {
            JediKnight Toby = new JediKnight ( "Toby", 21, "Chagrian", 72 );
            Toby.Intro();
            Console.WriteLine($"\n\tIt's {nombre}'s turn to learn the ways of the force!");
            return destiny();
        }
        static void Main(string[] args)
        {
            try
            {
                destiny();  // I had no idea I was going to make what I did
            }
            catch(FormatException) 
            {
                destiny();
            }
            finally
            {
                Console.WriteLine("The program has terminated");
            }
        }
        public static string stormTroopPath()
        {
            StormTrooper dude = new StormTrooper("New guy", aName:Console.ReadLine(), 18, "Human", 68);
            StormTrooper bob = new StormTrooper("Liar",aName: "Lyzo", 19, "Human", 68);
            bob.NameYourself();
            string aName = Console.ReadLine().ToLower();
            string nombre = aName; // To pass off object name that is a readline
            if ((aName == " ") || (aName == "")) return stormTroopPath();
            Console.WriteLine($"\n\tWelcome to the empire {aName}!");
            bob.Train();
            bob.Job();
            string choice = Console.ReadLine().ToLower();
            Random r = new Random(); //random variable
            var list = new List<string> { "machinegunner", "sniper", "pilot", "engineer" }; 
            int career = r.Next(list.Count); // Random index
            string lucky = (list[career]); // String of random index
            Console.WriteLine($"\n\tlooks like you got {lucky}"); // Maybe you got lucky??
            if (choice == lucky)
            {
                if (choice == "machinegunner") return MachineGunPath(dude, nombre);
                if (choice == "sniper") return SniperPath(dude, nombre);
                if (choice == "pilot") return PilotPath(dude, nombre);
                if (choice == "engineer") return EngineerPath(dude, nombre);
            }
            else if (choice != lucky) return UnluckyPath(nombre);  //Looks like you didn't
            return "The End";
        }
        public static string EngineerPath(StormTrooper dude, string nombre)
        {           
            Engineer Bobby = new Engineer ("Bobby", aName: "Brandon", 22,"Gand", 66 );
            Bobby.BuildStuff();
            Console.WriteLine($"\n\t{nombre} is going to build alot of stuff");            
            return "The force";
        }          
        public static string PilotPath(StormTrooper dude, string nombre)
        {
            Pilot Chuck = new Pilot("Chuck", aName: "Charles", 22, "Wookie", 94);
            Chuck.Flyer();
            Console.WriteLine($"\n\t{nombre} is never flying");
            return "The force";
        }
        public static string UnluckyPath(string nombre)
        {
            StormTrooper guy = new StormTrooper("New guy", aName: Console.ReadLine(), 18, "Talz", 70);
            guy.BadLuck();
            Console.WriteLine($"\n\t{nombre} is so unlucky");            
            return destiny();
        }
        public static string SniperPath(StormTrooper dude, string nombre)
        {
            Sniper Legend = new Sniper("UnSeen One", aName: "John", 42, "Human", 72);
            Legend.Sneaky();
            Legend.Champ();
            Console.WriteLine($"\n\tLets make you a sniper {nombre}.");
            return "The force";
        }
        public static string MachineGunPath(StormTrooper dude, string nombre)
        {
            MachineGunner Wambo = new MachineGunner("Rockman", aName: "Ronald", 22, "Human", 67);
            Wambo.Truth();
            Console.WriteLine($"\n\tYou'll know that soon {nombre}.");
            return "The force"; // Not inteneded to dislpay, only needed to pass the object
        }
    }
}
