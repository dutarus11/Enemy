using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    class Demon : Stats, IAbilities
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

        //the action method
        public Demon(int fire, int thunder, bool death, int poison, bool block, int strikeDMG, bool action, string strike)
        {
            this.Fire =- fire;
            this.Thunder =- thunder;
            this.Death = block;
            this.Poison =+ poison;
            this.Block = block;
            this.StrikeDMG =- strikeDMG;
            this.action = action;
            this.Strike = strike;

        }
        public void Action()
        {
            Console.WriteLine("The Demon Spawn attacks the his enemy with the Fire Spell!");

            if (action == true)
            {
                StrikeDMG = Fire;
                //int total = Fire += StrikeDMG;
                Console.WriteLine($"Fire Spell: {Fire} and the Enemy losses:{StrikeDMG}HP");

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

            Console.WriteLine("Class: Demon Spawn\n " + "Level: {0}\n" + "HP: {1}\n" + "MP: {2}\n" + "AttackDMG: {3}\n" +
                "MagDMG: {4}\n" + "DefPOW: {5}\n" + "IntLV: {6}\n" + "Speed: {7}", lv, hp, mp, attackDMG, magDMG, defPOW, intLV, speed);
            Console.WriteLine();
        }

    }
}
