using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class Heal : Skill
    {
        public Heal() 
        {
            this.skillName = SkillList.Heal;
        }

        public void Healing()
        {
            skillPower = 10;
            skillhealPoint = skillPower+player.playerAttackPoint;
            player.playercurHP += skillhealPoint;
            Console.WriteLine($"{player.playercurHP}(+{skillhealPoint})만큼 회복됐습니다.");
        }
    }
}
