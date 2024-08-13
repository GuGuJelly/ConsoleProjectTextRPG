using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike.Player
{
    public class Player
    {
        public string name;
        public int level;
        public int hp;
        public int curHP;
        public int mp;
        public int curMP;
        public int attackPoint;
        public int defencePoint;
        public SkillList[] playerSkill;

        public Player(string name) 
        {
            this.name = name; 
            level = 1;
            hp = 100;
            curHP = 100;
            mp = 100;
            curMP = 100;
            attackPoint = 20;
            defencePoint = 10;
            playerSkill = new SkillList[(int)SkillList.Size];
            playerSkill[0] = SkillList.Slash;
            playerSkill[1] = SkillList.Guard;
            foreach (SkillList a in playerSkill)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void Attack(Monster monster)
        {

        }
    }
}
