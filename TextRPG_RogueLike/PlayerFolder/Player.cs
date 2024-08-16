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
        public List<Skill> playerSkill = new List<Skill>();
        public Skill skill;
        public Monster monster;
        public MonsterBuilder monsterBuilder;
        public Game game;

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
            playerSkill.Add(new Slash(this));
            playerSkill.Add(new Guard(this));
            playerSkill.Add(new FireBall(this));
            playerSkill.Add(new IceShield(this));
            playerSkill.Add(new Heal(this));
        }


        public void SlashPlayer()
        {
            //playerSkill[0]
            Console.WriteLine("슬래쉬로 몬스터를 공격합니다");
            

            //game.monsterFactory.monsterCurHP -= skill.skillTotalDamage - game.monster.monsterDefencePoint;
            Console.WriteLine($"몬스터에게 {playerSkill[0].skillTotalDamage - monster.monsterDP} 만큼의 데미지를 주었습니다.");
        }

        public void GuardPlayer()
        {
            Console.WriteLine("당신은 몬스터의 공격을 막습니다.");
            playercurHP -= 1;
            Console.WriteLine("당신은 몬스터의 공격을 성공적으로 막고 -1 의 데미지를 입었습니다.");
        }

        public void FirBallPlayer()
        {
            Console.WriteLine("당신은 FireBall로 몬스터를 공격합니다.");
            monsterBuilder.monstercurHP -= skill.skillDamage - monsterBuilder.monsterDP;
            Console.WriteLine($"{SkillList.FireBall}로 {skill.skillDamage - monsterBuilder.monsterDP} 만큼의 데미지를 주었습니다.");
        }

        public void IceShieldPlayer()
        {
            Console.WriteLine("당신은 IceShield를 사용하여 방어력을 높입니다.");
            IceShieldPlayer();
            
            Console.WriteLine($"당신은 방어력이 {IceShieldPlayer} 만큼 상승했습니다.");
        }

        public void HealPlayer()
        {
            Console.WriteLine("당신은 Heal을 사용하여 회복합니다.");
            game.heal.Healing();
            Console.WriteLine($"당신은 체력이 {game.heal.skillhealPoint} 만큼 회복합니다.");
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
            Console.WriteLine($"스킬 : {playerSkill[0]}, {playerSkill[1]}, {playerSkill[2]}, {playerSkill[3]}");
            // 이 부분은 원래 플레이어가 스킬을 습득하면 playerSkill[2][3]  이 오픈되게 만들려고 했는데, 리스트가 자꾸 터져서 일단 보류해놨습니다.
            // 지금 생각해보면 이 부분은 가중치 그래프로 하는게 맞지 않나 생각이 들었습니다. 
            //if (playerSkill[2] == SkillList.FireBall || playerSkill[2] == SkillList.Heal || playerSkill[2] == SkillList.IceShield) 
            //{
            //    Console.Write($"마법 : {playerSkill[2]}, ");
            //}
            //else if ((playerSkill[3] != playerSkill[2]) && (playerSkill[3] == SkillList.FireBall || playerSkill[3] == SkillList.Heal || playerSkill[3] == SkillList.IceShield))
            //{
            //    Console.Write($"{playerSkill[3]}");
            //} else
            Console.WriteLine();
            
        }
    }
}
