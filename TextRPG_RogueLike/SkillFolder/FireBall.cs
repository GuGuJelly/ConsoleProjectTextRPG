using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class FireBall : Skill
    {
        public FireBall(Player player) : base(player)
        {
            this.skillName = SkillList.FireBall;
            //this.player.playercurMP -= 5;
            player.playercurMP -= 5;
            this.skillPower = 20;
            this.skillDamage = player.playerAttackPoint + skillPower;
        }
    }
}
