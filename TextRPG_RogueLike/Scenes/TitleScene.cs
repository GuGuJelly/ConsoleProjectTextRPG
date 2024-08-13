using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike.Scenes
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

        public override void Input()
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
        }

        public override void Update()
        {
            Thread.Sleep(2000);
            game.ChangeScene(SceneType.Select);
        }
    }
}
