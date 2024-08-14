using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using TextRPG_RogueLike.SceneFolder;

namespace TextRPG_RogueLike
{
    
    public class SelectScene : Scene
    {
        public enum State { Name, Job, Confirm }
        private State curState;

        private string input;
        private string nameInput;
        
        Player player = new Player();
        public SelectScene(Game game) : base(game)
        {
            
        }
        public override void Enter()
        {
            curState = State.Name;
        }

        public override void Exit()
        {
            Console.WriteLine("게임을 시작하겠습니다.");
        }

        public override void Input()
        {
            input = Console.ReadLine();
        }

        public override void Render()
        {
            Console.Clear();
            if (curState == State.Name)
            {
                Console.Write("캐릭터의 이름을 입력하세요 : ");
            }else if(curState == State.Confirm) 
            {
                Console.WriteLine("===================");
                Console.WriteLine($"이름 : {player.playername}");
                Console.WriteLine($"체력 : {player.playercurHP}/{player.playermaxHP}");
                Console.WriteLine($"MP : {player.playercurMP}/{player.playermaxMP}");
                Console.WriteLine($"공격 : {player.playerAttackPoint}");
                Console.WriteLine($"방어 : {player.playerdefencePoint}");
                Console.WriteLine($"소지금 : {player.playerGold}");
                Console.WriteLine($"스킬 : {player.playerSkill[0]}, {player.playerSkill[1]}");
                Console.WriteLine("===================");
                Console.WriteLine();
                Console.Write("이대로 플레이 하시겠습니까?(y/n)");
            }
        }

        public override void Update()
        {
            if (curState == State.Name)
            {
                if (input == string.Empty)
                    return;

                nameInput = input;
                player.playername = nameInput;
                curState = State.Confirm;
            }
            else if (curState == State.Confirm)
            {
                switch (input)
                {
                    case "Y":
                    case "y":
                        game.ChangeScene(SceneType.SafeHouse);
                        break;
                    case "N":
                    case "n":
                        curState = State.Name;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

