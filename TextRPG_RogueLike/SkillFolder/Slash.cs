using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class Slash : Skill
    {
        public Slash(Player player) : base(player)
        {
            this.skillName = SkillList.Slash;
            this.skillPower = 10;
            //playerAttackPoint + skillPower
            this.skillDamage = player.playerAttackPoint + skillPower;/*플레이어 공격력 + skillPower*/
        }  
    }
}
