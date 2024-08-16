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
                Console.WriteLine($"이름 : {game.Player.playername}");
                Console.WriteLine($"체력 : {game.Player.playercurHP}/{game.Player.playermaxHP}");
                Console.WriteLine($"MP : {game.Player.playercurMP}/{game.Player.playermaxMP}");
                Console.WriteLine($"공격 : {game.Player.playerAttackPoint}");
                Console.WriteLine($"방어 : {game.Player.playerdefencePoint}");
                Console.WriteLine($"소지금 : {game.Player.playerGold}");
                Console.WriteLine($"스킬 : {game.Player.playerSkill[0]}, {game.Player.playerSkill[1]}");
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
                game.Player.playername = nameInput;
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

