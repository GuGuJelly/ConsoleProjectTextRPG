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
            int spawnMonster = random.Next((int)MonsterType.Slime, (int)MonsterType.RatMan);
            
            switch (spawnMonster)
            {
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크와 조우했습니다.");
                    //game.monster Orc0 = game.OrcBuilder.Build();
                    MonsterBuilder OrcBuilder = new MonsterBuilder();
                    OrcBuilder.SetmName("오크");
                    OrcBuilder.SetMonsterType(MonsterType.Orc);
                    OrcBuilder.SetMonstermaxHP(200);
                    OrcBuilder.SetMonstercurHP(200);
                    OrcBuilder.SetMonstermaxMP(10);
                    OrcBuilder.SetMonstercurMP(10);
                    OrcBuilder.SetMonsterAP(40);
                    OrcBuilder.SetMonsterDP(10);
                    OrcBuilder.SetDropItem(ItemType.AllPotion);
                    Monster Orc = new Monster();
                    Orc = OrcBuilder.Build();
                    break;
               
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임 과 조우했습니다.");
                    MonsterBuilder SlimeBuilder = new MonsterBuilder();
                    SlimeBuilder.SetmName("슬라임");
                    SlimeBuilder.SetMonsterType(MonsterType.Slime);
                    SlimeBuilder.SetMonstermaxHP(150);
                    SlimeBuilder.SetMonstercurHP(150);
                    SlimeBuilder.SetMonstermaxMP(10);
                    SlimeBuilder.SetMonstercurMP(10);
                    SlimeBuilder.SetMonsterAP(30);
                    SlimeBuilder.SetMonsterDP(20);
                    SlimeBuilder.SetDropItem(ItemType.LongSword);
                    Monster Slime = new Monster();
                    Slime = SlimeBuilder.Build();
                    break;
               
                case (int)MonsterType.RatMan:
                    Console.WriteLine("랫맨 과 조우했습니다.");
                    MonsterBuilder RatManBuilder = new MonsterBuilder();
                    RatManBuilder.SetmName("랫맨");
                    RatManBuilder.SetMonsterType(MonsterType.RatMan);
                    RatManBuilder.SetMonstermaxHP(300);
                    RatManBuilder.SetMonstercurHP(300);
                    RatManBuilder.SetMonstermaxMP(10);
                    RatManBuilder.SetMonstercurMP(10);
                    RatManBuilder.SetMonsterAP(25);
                    RatManBuilder.SetMonsterDP(15);
                    RatManBuilder.SetDropItem(ItemType.TowerShield);
                    Monster RatMan = new Monster();
                    RatMan = RatManBuilder.Build();
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
