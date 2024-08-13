using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike.Skill
{
    public class Skill
    {
        public string skillName;
        public int attackPoint;
        public int healPoint;
        public int defencePoint;


        public Skill()
        {
            skillName = "아무개";
            attackPoint = 1;
            healPoint = 1;
            defencePoint = 1;
        }

    }
}
