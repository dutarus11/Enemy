using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    class Human : Stats, IAbilities
    {
        //Effective Action
        public bool action { get; set; }

        //Elemental Spells 
        public int Fire { get; set; }
        public int Ice { get; set; }
        public int Thunder { get; set; }
        public int Wind { get; set; }

        //Ailment Spells

        public bool Death { get; set; }
        public int Poison { get; set; }

        //Healing Spells
        public bool Life { get; set; }
        public int Heal { get; set; }
        public bool Cure { get; set; }

        //Physical Attack Abilities 
        public string Strike { get; set; }
        public int StrikeDMG { get; set; }
        //physical defense
        public bool Block { get; set; }
        public int DefensePWR { get; set; }

        public Human(int thunder, int ice, bool cure, string strike, int strikeDMG, bool block, bool action)
        {
            this.Thunder =- thunder;
            this.Ice =- ice;
            this.Cure = cure;
            this.Strike = strike;
            this.Block = block;
            this.StrikeDMG =- strikeDMG;
            this.action = action;

        }

        //the action method
        public void Action()
        {
            Console.WriteLine("The Human Warrior is attacked by Demon Spawn and blocks his attack!");

            if (action == true && Block == true)
            {
                Console.WriteLine($"The Human Warrior received: {StrikeDMG} damaged.");
                StrikeDMG = Thunder;
                //int total = Fire += StrikeDMG;
                Console.WriteLine("The Human Warrior casts the Thunder Spell on Demon Spawn!");
                Console.WriteLine($"Thunder Spell: {Thunder} and the Enemy losses:{StrikeDMG}HP");

            }
            else
            {
                Console.WriteLine("Turn skipped");
            }
            Console.WriteLine();
        }

        public void Stats(int lv, int hp, int mp, int attackDMG, int magDMG, int defPOW, int intLV, int speed)
        {
            this.Lv = lv;
            this.Hp = hp;
            this.Mp = mp;
            this.AttackDMG = attackDMG;
            this.MagDMG = magDMG;
            this.DefPOW = defPOW;
            this.IntLV = intLV;
            this.Speed = speed;

            Console.WriteLine("Class: Human\n " + "Level: {0}\n" + "HP: {1}\n" + "MP: {2}\n" + "AttackDMG: {3}\n" +
                "MagDMG: {4}\n" + "DefPOW: {5}\n" + "IntLV: {6}\n" + "Speed: {7}", lv, hp, mp, attackDMG, magDMG, defPOW, intLV, speed);
            Console.WriteLine();
        }

    }
}
