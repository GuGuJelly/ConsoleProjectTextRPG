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
            this.skillTotalDamage = monster.monsterDefencePoint - skillDamage;

            monster.monsterCurHP -= skillTotalDamage;
            Console.WriteLine($"몬스터에게 {skillName}을 사용하여 {skillTotalDamage} 만큼의 데미지를 입혔습니다. ");
        }  
    }
}
