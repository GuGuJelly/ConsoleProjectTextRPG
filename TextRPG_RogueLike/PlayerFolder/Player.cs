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
        public int playermaxHP;
        public int playercurHP;
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
            playername = "";
            playerlevel = 1;
            playermaxHP = 100;
            playercurHP = 100;
            playermaxMP = 100;
            playercurMP = 100;
            playerAttackPoint = 20;
            playerdefencePoint = 10;
            playerGold = 50;
            playerSkill = new List<SkillList>() { SkillList.Slash, SkillList.Guard };

            
            
        }

        public void AttackPlayer(Game game)
        {
            Console.WriteLine("플레이어가 공격을 합니다.");
            
        }
    }
}
