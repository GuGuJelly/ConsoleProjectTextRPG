using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike.Monster
{
    public class Monster
    {
        public string monsterName;
        public int monsterLevel;
        public int monstermaxHP;
        public int monsterCurHP;
        public int monstermaxMP;
        public int monsterCurMP;

        public Monster(string monsterName) 
        {
            monsterName = "";
            monsterLevel = 1;
            monsterHP = 100;

        }
    }
}
