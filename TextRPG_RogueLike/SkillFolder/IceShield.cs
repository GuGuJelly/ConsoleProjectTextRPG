using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    
    public class IceShield : Skill
    {

        public IceShield(Player player) : base(player)
        {
            this.skillName = SkillList.IceShield;
        }
        
        public void DefenceUp(Player player)
        {
            
            this.skillPower = 5;
            this.skillDefence = skillPower;
            this.player.playerBuffDeffence += skillPower;
        }
    }
}
