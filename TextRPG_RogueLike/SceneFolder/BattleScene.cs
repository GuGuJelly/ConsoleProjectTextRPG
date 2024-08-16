using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
   
    public class BattleScene : Scene
    {
        
        private int input;
        
        public BattleScene(Game game) : base(game)
        {

        }
        public override void Enter()
        {
            Console.WriteLine("당신은 검을 듭니다.");
        }

        public override void Exit()
        {
            Console.WriteLine("방을 빠져나갑니다.");
        }

        public override void Input()
        {
            Console.WriteLine("전투를 위해 숫자를 입력해주세요 : ");
            Console.WriteLine("1. 슬래쉬 2. 가드 3. 파이어볼 4. 얼음갑옷 5. 힐");
            Console.WriteLine("");
            int.TryParse(Console.ReadLine(),out input);
        }

        public override void Render()
        {
            Random random = new Random();
            int spownMonster = random.Next((int)MonsterType.Slime, (int)MonsterType.RatMan);
            
            switch (spownMonster)
            {
                case (int)MonsterType.Orc:
                    game.OrcFactory.SetmName("Orc");
                    Console.WriteLine("Orc와 조우했습니다.");
                    game.OrcFactory.SetMonsterType(MonsterType.Orc);
                    game.OrcFactory.SetMonstermaxHP(200);
                    game.OrcFactory.SetMonstercurHP(200);
                    game.OrcFactory.SetMonstermaxMP(10);
                    game.OrcFactory.SetMonstercurMP(10);
                    game.OrcFactory.SetMonsterAP(40);
                    game.OrcFactory.SetMonsterDP(10);
                    game.OrcFactory.SetDropItem(ItemType.AllPotion);
                    break;

                case (int)MonsterType.Slime:
                    game.SlimeFactory.SetmName("Slime");
                    Console.WriteLine("Slime 과 조우했습니다.");
                    game.SlimeFactory.SetMonsterType(MonsterType.Slime);
                    game.SlimeFactory.SetMonstermaxHP(150);
                    game.SlimeFactory.SetMonstercurHP(150);
                    game.SlimeFactory.SetMonstermaxMP(10);
                    game.SlimeFactory.SetMonstercurMP(10);
                    game.SlimeFactory.SetMonsterAP(30);
                    game.SlimeFactory.SetMonsterDP(20);
                    game.SlimeFactory.SetDropItem(ItemType.LongSword);
                    break;

                case (int)MonsterType.RatMan:
                    game.RatManFactory.SetmName("RatMan");
                    Console.WriteLine("RatMan 과 조우했습니다.");
                    game.RatManFactory.SetMonsterType(MonsterType.RatMan);
                    game.RatManFactory.SetMonstermaxHP(300);
                    game.RatManFactory.SetMonstercurHP(300);
                    game.RatManFactory.SetMonstermaxMP(10);
                    game.RatManFactory.SetMonstercurMP(10);
                    game.RatManFactory.SetMonsterAP(25);
                    game.RatManFactory.SetMonsterDP(15);
                    game.RatManFactory.SetDropItem(ItemType.TowerShield);
                    break;
            }
        }

        public override void Update()
        {
            switch (input)
            {
                case 1:
                    game.Player.SlashPlayer();
                    break;

                case 2:
                    game.Player.GuardPlayer();
                    break;

                case 3:
                    game.Player.FirBallPlayer();
                    break;

                case 4:
                    game.Player.IceShieldPlayer();
                    break;

                case 5:
                    game.Player.HealPlayer();
                    break;
            }

            if (game.monster.monstercurHP <= 0 ) 
            {
                game.Player.playerBuffDeffence = game.Player.playercurHP;
                game.ChangeScene(SceneType.MonsterRoom);
            }
            
        }
    }
}
