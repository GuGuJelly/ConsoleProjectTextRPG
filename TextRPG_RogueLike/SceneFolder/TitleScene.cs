using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class TitleScene : Scene
    {
        
        public TitleScene(Game game) : base(game) 
        {

        }
        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }

        public override void Render()
        {
            Console.WriteLine("##########################################");
            Console.WriteLine("#                                        #");
            Console.WriteLine("#                                        #");
            Console.WriteLine("#            RogueLike Battle            #");
            Console.WriteLine("#                                        #");
            Console.WriteLine("#                                        #");
            Console.WriteLine("##########################################");

            Console.WriteLine("                 게임 시작                 ");

        }

        public override void Input()
        {
            Console.WriteLine("계속하려면 아무 키나 누르세요 ");
            Console.ReadKey();
        }

        public override void Update()
        {
            game.ChangeScene(SceneType.Select);// 작동을 안합니다
        }
    }
}
