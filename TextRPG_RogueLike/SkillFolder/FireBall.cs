﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class FireBall : Skill
    {
        public FireBall()
        {
            this.skillName = SkillList.FireBall;
            this.player.playercurMP -= 5;
            this.skillPower = 20;
            this.skillDamage = player.playerAttackPoint + skillPower;
        }
    }
}
