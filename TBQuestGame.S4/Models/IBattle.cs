using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    interface IBattle
    {
        int SkillLevel { get; set; }
        //game uses items as weapons
        Weapon CurrentWeapon { get; set; }
        BattleModeName BattleMode { get; set; }

        //methods to return values
        int Attack();
        int Defend();
        int Retreat();
    }
}
