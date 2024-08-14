using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class Monster
    {
        public string monsterName;
        public int monsterLevel;
        public int monstermaxHP;
        public int monsterCurHP;
        public int monstermaxMP;
        public int monsterCurMP;
        public int monsterAttackPoint;
        public int monsterDefencePoint;

        public Monster(string monsterName) 
        {
            this.monsterName = "아무개";
            monsterLevel = 1;
            monstermaxHP = 100;
            monsterCurHP = 100;
            monstermaxMP = 30;
            monsterCurMP = 30;
            monsterAttackPoint = 20;
            monsterDefencePoint = 5;

        }
    }
}
