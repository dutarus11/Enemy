using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    interface IAbilities
    {
        //Actions 
        bool action { get; set; }
        //Elemental Spells
        int Fire { get; set; }
        int Ice { get; set; }
        int Thunder { get; set; }
        int Wind { get; set; }

        //Ailment Spells

        bool Death { get; set; }
        int Poison { get; set; }

        //Healing Spells
        bool Life { get; set; }
        int Heal { get; set; }
        bool Cure { get; set; }

        //Physical Attack Abilities 
        string Strike { get; set; }
        int StrikeDMG { get; set; }
        //physical defense
        bool Block { get; set; }
        int DefensePWR { get; set; }

        //Action Method 
        void Action();
        
       



       

    }
}
