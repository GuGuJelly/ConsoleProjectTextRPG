using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public int playerBuffDeffence;
        public int playerGold;
        public SkillList skillList;
        public List<SkillList> playerSkill = new List<SkillList>();
        public Skill skill;
        public Monster monster;

        public Player() 
        {
            playername = string.Empty;
            playerlevel = 1;
            playermaxHP = 100;
            playercurHP = 100;
            playermaxMP = 100;
            playercurMP = 100;
            playerAttackPoint = 20;
            playerdefencePoint = 10;
            playerBuffDeffence = playerdefencePoint;
            playerGold = 50;
            playerSkill.Add(SkillList.Slash);
            playerSkill.Add(SkillList.Guard);
        }

        public void AttackPlayer()
        {
            Console.WriteLine("플레이어가 공격을 합니다.");
            
            switch (skillList) 
            {
                case SkillList.Slash:
                    Console.WriteLine("슬래쉬로 몬스터를 공격합니다");
                    monster.monsterCurHP -= skill.skillTotalDamage - monster.monsterDefencePoint;
                    break;

                case SkillList.Guard:
                    Console.WriteLine("당신은 몬스터의 공격을 막습니다.");
                    playercurHP -= 1;
                    break;

                case SkillList.FireBall:
                    Console.WriteLine("당신은 FireBall로 몬스터를 공격합니다.");
                    monster.monsterCurHP -=  skill.skillDamage - monster.monsterDefencePoint;
                    break;

                case SkillList.IceShield:
                    Console.WriteLine("당신은 IceShield를 사용하여 방어력을 높입니다.");
                    IceShield iceShield = new IceShield();
                    iceShield.DefenceUp();
                    break;

                case SkillList.Heal:
                    Console.WriteLine("당신은 Heal을 사용하여 회복합니다.");
                    Heal heal = new Heal();
                    heal.Healing();
                    break;
            }
        }

        public void ShowPlayer()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"이름 : {playername}");
            Console.WriteLine($"체력 : {playercurHP}/{playermaxHP}");
            Console.WriteLine($"MP : {playercurMP}/{playermaxMP}");
            Console.WriteLine($"공격 : {playerAttackPoint}");
            Console.WriteLine($"방어 : {playerdefencePoint}");
            Console.WriteLine($"소지금 : {playerGold}");
            Console.WriteLine($"스킬 : {playerSkill[0]}, {playerSkill[1]}");
            if (playerSkill[2] == SkillList.FireBall || playerSkill[2] == SkillList.Heal || playerSkill[2] == SkillList.IceShield) 
            {
                Console.Write($"마법 : {playerSkill[2]}, ");
            }
            else if ((playerSkill[3] != playerSkill[2]) && (playerSkill[3] == SkillList.FireBall || playerSkill[3] == SkillList.Heal || playerSkill[3] == SkillList.IceShield))
            {
                Console.Write($"{playerSkill[3]}");
            } else
                Console.WriteLine();
            
        }
    }
}
