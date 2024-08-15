using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class Slash : Skill
    {
        public Slash() 
        {
            this.skillName = SkillList.Slash;
            this.skillPower = 10;
            this.skillDamage = player.playerAttackPoint + skillPower;
        }  
    }
}
