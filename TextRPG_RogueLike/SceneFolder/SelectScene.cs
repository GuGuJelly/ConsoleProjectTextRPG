using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace TextRPG_RogueLike
{
    public class SelectScene : Scene
    {
        private enum State { Name, Confirm }
        private State curState;
        private string input;
        
        public SelectScene(Game game) : base(game)
        {
            
        }
        public override void Enter()
        {
            Console.WriteLine("캐릭터를 생성합니다.");
        }

        public override void Exit()
        {
            throw new NotImplementedException();
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
            }
            else if (curState == State.Confirm) 
            {
                Console.WriteLine("===================");
                Console.WriteLine($"이름 : {game.Player.playername}");
                Console.WriteLine($"체력 : {game.Player.playermaxHP}");
                Console.WriteLine($"공격 : {game.Player.playername}");
                Console.WriteLine($"방어 : {game.Player.playerdefencePoint}");
                Console.WriteLine($"소지금 : {game.Player.playerGold}");
                Console.WriteLine($"스킬 : {game.Player.playerSkill}");
                Console.WriteLine("===================");
                Console.WriteLine();
                Console.Write("이대로 플레이 하시겠습니까?(y/n)");
            }

        }

        public override void Update()
        {
            Console.WriteLine($"캐릭터의 이름을 입력해주세요 : ");
            

        }
    }
}
