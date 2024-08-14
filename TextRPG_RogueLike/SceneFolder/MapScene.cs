using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class MapScene : Scene
    {
        public SceneType scenes;
        //private bool[,] mapPos;
        public SceneType playerPos;
        public SceneType goalPos;

        public MapScene(Game game) : base(game)
        {

            //mapPos = new bool[,]
            //{
            //    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false,false },
            //    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true },
            //    { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true },
            //    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            //    { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }
            //};

            //for (int y = 0; y < mapPos.GetLength(0);y++) 
            //{
            //    for (int x = 0; x < mapPos.GetLength(1); x++) 
            //    {
            //        if (mapPos[y, x])
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("#");
            //        }
            //    }
            //}

            LinkedList<SceneType> linkedListMap = new LinkedList<SceneType>();
            LinkedListNode<SceneType> node1 = linkedListMap.AddFirst(SceneType.SafeHouse);
            LinkedListNode<SceneType> node2 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node3 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node4 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node5 = linkedListMap.AddLast(SceneType.BossMonsterRoom);
            LinkedListNode<SceneType> node6 = linkedListMap.AddLast(SceneType.Shop);
            LinkedListNode<SceneType> node7 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node8 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node9 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node10 = linkedListMap.AddLast(SceneType.BossMonsterRoom);
            LinkedListNode<SceneType> node11 = linkedListMap.AddLast(SceneType.Shop);
            LinkedListNode<SceneType> node12 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node14 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node15 = linkedListMap.AddLast(SceneType.MonsterRoom);
            LinkedListNode<SceneType> node16 = linkedListMap.AddLast(SceneType.BossMonsterRoom);
            LinkedListNode<SceneType> node17 = linkedListMap.AddLast(SceneType.Shop);
            LinkedListNode<SceneType> node18 = linkedListMap.AddLast(SceneType.BossMonsterRoom);

            playerPos = linkedListMap.First();
            goalPos = linkedListMap.Last();


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
            throw new NotImplementedException();
        }


    }

        
    }

