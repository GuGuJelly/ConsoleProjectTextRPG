using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike.Scenes
{
    public class MapScene : Scene
    {
        public SceneType scenes;
        //private bool[,] mapPos;
        private int playerPos;
        public int goalPos;

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

            LinkedList<int> linkedListMap = new LinkedList<int>();
            LinkedListNode<int> node1 = linkedListMap.AddFirst((int)SceneType.SafeHouse);
            LinkedListNode<int> node2 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node3 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node4 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node5 = linkedListMap.AddLast((int)SceneType.BossMonsterRoom);
            LinkedListNode<int> node6 = linkedListMap.AddLast((int)SceneType.Shop);
            LinkedListNode<int> node7 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node8 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node9 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node10 = linkedListMap.AddLast((int)SceneType.BossMonsterRoom);
            LinkedListNode<int> node11 = linkedListMap.AddLast((int)SceneType.Shop);
            LinkedListNode<int> node12 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node14 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node15 = linkedListMap.AddLast((int)SceneType.MonsterRoom);
            LinkedListNode<int> node16 = linkedListMap.AddLast((int)SceneType.BossMonsterRoom);
            LinkedListNode<int> node17 = linkedListMap.AddLast((int)SceneType.Shop);
            LinkedListNode<int> node18 = linkedListMap.AddLast((int)SceneType.BossMonsterRoom);

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

