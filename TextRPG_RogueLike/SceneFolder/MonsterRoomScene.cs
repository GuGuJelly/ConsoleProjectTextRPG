using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class MonsterRoomScene : Scene
    {
        private string input;
        
        public MonsterRoomScene(Game game) : base(game)
        {

        }
        public override void Enter()
        {
            Console.WriteLine("통로를 지나왔더니 또 다른 동굴의 방을 발견했습니다.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("동굴의 한가운데에는 몬스터로 보이는 괴물이 자리잡고 있습니다.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("그 몬스터는 당신을 발견하자마자 달려듭니다.");
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        public override void Exit()
        {
            Console.WriteLine("방을 떠납니다");
        }

        public override void Input()
        {
            Console.WriteLine("싸울 준비를 위해 아무키나 누르세요");
            input = Console.ReadLine();
        }

        public override void Render()
        {
            
        }
        public override void Update()
        {
            game.ChangeScene(SceneType.Battle);
        }
    }
}
