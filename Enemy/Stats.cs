using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
        
        //stats of enemies 
        class Stats
        {
            public int Lv { get; set; }
            public int Hp { get; set; }
            public int Mp { get; set; }
            public int AttackDMG { get; set; }
            public int MagDMG { get; set; }
            public int DefPOW { get; set; }
            public int IntLV { get; set; }

            public int Speed { get; set; }

            public Stats()
            {
                this.Lv = 0;
                this.Mp = 0;
                this.AttackDMG = 0;
                this.MagDMG = 0;
                this.DefPOW = 0;
                this.IntLV = 0;
                this.Speed = 0;
            }
            public Stats(int lv, int hp, int mp, int attackDMG, int magDMG, int defPOW, int intLV, int speed)
            {
                this.Lv = lv;
                this.Mp = mp;
                this.AttackDMG = attackDMG;
                this.MagDMG = magDMG;
                this.DefPOW = defPOW;
                this.IntLV = intLV;
                this.Speed = speed;
            }
        }
    
}
