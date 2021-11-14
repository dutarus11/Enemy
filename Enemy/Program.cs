using System;

namespace Enemy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objective - Create 4 different enemies or players that have 4 different classes
            //defining their race & job description, 1 class called Stats that contain all their level
            //parameters. Then create 1 interface that contains all of their abilities and actions etc. 

            //creating type dwarf warrior 
            Dwarf dwarfWarrior = new Dwarf("Battle Axe", true, true);
            dwarfWarrior.Stats(3, 6, 0, 6, 0, 2, 3, 1);
            dwarfWarrior.Action();
                        

            //creating Angelic being
            Angel angelicBeing = new Angel(2, 1, true, 2, 0, false, true);
            angelicBeing.Stats(8, 10, 8, 5, 6, 5, 8, 8);
            angelicBeing.Action();
            
            //creating Demonic Spawn 
            Demon demonSpawn = new Demon(2, 2, true, 1, false, 0, true, "Scratch");
            demonSpawn.Stats(7, 7, 4, 4, 6, 4, 6, 5);
            demonSpawn.Action();

            //creating Human Warrior 
            Human humanWarrior = new Human(4, 2, true, "Sword", 0, true, true);
            humanWarrior.Stats(3, 4, 2, 2, 3, 2, 3, 5);
            humanWarrior.Action();
        }
    }
}
