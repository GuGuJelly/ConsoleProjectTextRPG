using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class Skill
    {
        public Player player;
        
        public SkillList skillName;
        public int skillPower;
        public int skillDefence;
        public int skillDamage;
        public int skillTotalDamage;
        public int skillhealPoint;
        public int skillDP;
        public Monster monster;

        public Skill(Player player) 
        {
            
        }
        
    }
}
