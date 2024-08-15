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
            Random random = new Random();
            int spownMonster = random.Next((int)MonsterType.Slime,(int)MonsterType.RatMan);
            switch (spownMonster)
            {
                case (int)MonsterType.Orc:
                    game.monsterFactory.SetmName("Orc");
                    Console.WriteLine("Orc와 조우했습니다.");
                    game.monsterFactory.SetMonsterType(MonsterType.Orc);
                    game.monsterFactory.SetMonstermaxHP(200);
                    game.monsterFactory.SetMonstercurHP(200);
                    game.monsterFactory.SetMonstermaxMP(10);
                    game.monsterFactory.SetMonstercurMP(10);
                    game.monsterFactory.SetMonsterAP(40);
                    game.monsterFactory.SetMonsterDP(10);
                    game.monsterFactory.SetDropItem(ItemType.AllPotion);
                    break;

                case (int)MonsterType.Slime:
                    game.monsterFactory.SetmName("Slime");
                    Console.WriteLine("Slime 과 조우했습니다.");
                    game.monsterFactory.SetMonsterType(MonsterType.Slime);
                    game.monsterFactory.SetMonstermaxHP(150);
                    game.monsterFactory.SetMonstercurHP(150);
                    game.monsterFactory.SetMonstermaxMP(10);
                    game.monsterFactory.SetMonstercurMP(10);
                    game.monsterFactory.SetMonsterAP(30);
                    game.monsterFactory.SetMonsterDP(20);
                    game.monsterFactory.SetDropItem(ItemType.LongSword);
                    break;

                case (int)MonsterType.RatMan:
                    game.monsterFactory.SetmName("RatMan");
                    Console.WriteLine("RatMan 과 조우했습니다.");
                    game.monsterFactory.SetMonsterType(MonsterType.RatMan);
                    game.monsterFactory.SetMonstermaxHP(300);
                    game.monsterFactory.SetMonstercurHP(300);
                    game.monsterFactory.SetMonstermaxMP(10);
                    game.monsterFactory.SetMonstercurMP(10);
                    game.monsterFactory.SetMonsterAP(25);
                    game.monsterFactory.SetMonsterDP(15);
                    game.monsterFactory.SetDropItem(ItemType.TowerShield);
                    break;
            }
        }
        public override void Update()
        {
            game.ChangeScene(SceneType.Battle);
        }
    }
}
