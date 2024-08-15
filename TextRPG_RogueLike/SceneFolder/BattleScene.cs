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
        public BattleScene(Game game) : base(game)
        {

        }
        public override void Enter()
        {
            throw new NotImplementedException();
        }

        public override void Exit()
        {
            throw new NotImplementedException();
        }

        public override void Input()
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            if (player.playerBuffDeffence != player.playerdefencePoint)
            {
                player.playerBuffDeffence = player.playerdefencePoint;
            }
        }
    }
}
