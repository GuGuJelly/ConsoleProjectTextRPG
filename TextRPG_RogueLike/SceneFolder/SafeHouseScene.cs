using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class SafeHouseScene : Scene
    {
        public int input;
        public MapScene mapScene;
        
        public SafeHouseScene(Game game) : base(game)
        {

        }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("당신은 안전한 곳에서 눈을 뜹니다.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("주변을 둘러보니 군데군데 횃불로 밝혀진 동굴 안이었습니다");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("문득 당신의 오른손에는 단검, 왼손에는 둥근방패를 쥐고 있다는 것을 알았습니다.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("그리고 동굴의 한쪽에는 통로로 여겨지는 사람 한명이 겨우 간신히 지나갈만한 곳을 발견했습니다.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("다른 방법이 없는 당신은 그 통로를 통해 동굴을 빠져나가기로 결심합니다.");
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        public override void Exit()
        {
            throw new NotImplementedException();
        }

        public override void Input()
        {

            int.TryParse(Console.ReadLine(), out int input);
            if (input <= 0 || input > 2)
            {
                Input();
            }
        }

        public override void Render()
        {
            mapScene.Render();
            switch (input)
            {
                case 1:
                    Console.WriteLine("통로에 들어갑니다.");
                    game.ChangeScene(SceneType.MonsterRoom);
                    break;
                case 2:
                    Console.WriteLine("주변을 둘러봅니다.");
                    break;
            }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
