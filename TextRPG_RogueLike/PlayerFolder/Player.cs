using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class Player
    {
        public string playername;
        public int playerlevel;
        public int playerhp;
        public int playermaxHP;
        public int playercurHP;
        public int playermp;
        public int playermaxMP;
        public int playercurMP;
        public int playerAttackPoint;
        public int playerdefencePoint;
        public int playerGold;
        public Skill skill;
        public List<SkillList> playerSkill;
        public Monster Monster;

        public Player() 
        {
            this.playername = "";
            this.playerlevel = 1;
            this.playerhp = 100;
            this.playercurHP = 100;
            this.playermp = 100;
            this.playercurMP = 100;
            this.playerAttackPoint = 20;
            this.playerdefencePoint = 10;
            this.playerGold = 50;
            playerSkill = new List<SkillList>() { SkillList.Slash, SkillList.Guard };

            
            foreach (SkillList a in playerSkill)
            {
                Console.WriteLine($"{a}");
            }
        }

        public void AttackPlayer(Game game)
        {
            Console.WriteLine("플레이어가 공격을 합니다.");
            
        }
    }
}
