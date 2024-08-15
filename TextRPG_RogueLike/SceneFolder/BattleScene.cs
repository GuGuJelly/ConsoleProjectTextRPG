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
        public Player player;
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
            
        }

        public override void Update()
        {
            switch (input)
            {
                case 1:
                    player.SlashPlayer();
                    break;

                case 2:
                    player.GuardPlayer();
                    break;

                case 3:
                    player.FirBallPlayer();
                    break;

                case 4:
                    player.IceShieldPlayer();
                    break;

                case 5:
                    player.HealPlayer();
                    break;
            }

            if (game.monsterFactory.monstercurHP <= 0 ) 
            {
                game.player.playerBuffDeffence = game.player.playercurHP;
                game.ChangeScene(SceneType.MonsterRoom);
            }
            
        }
    }
}
