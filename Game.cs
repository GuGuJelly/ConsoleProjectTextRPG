using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TextRPG_RogueLike.Scenes;

namespace TextRPG_RogueLike
{
    public class Game
    {
        private bool isRunning;
        private MapScene mapScene;
        private SceneType playerPos;
        public SceneType goalPos;
        public SkillList skillList;
        public Player player;
        

        public void Run()
        {
            Start();
            while (isRunning) 
            {
                Render();
                Input();
                Update();
            }
        }

        public void ChangeScene(SceneType sceneType) 
        {
            
        }

        public void Over()
        {
            isRunning = false;
        }

        public void Start()
        {
            isRunning  = true;

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
            LinkedListNode<SceneType> node19 = linkedListMap.AddLast(SceneType.Goal);

            Console.WriteLine("당신은 이곳에서 살아나가야 합니다.");
            playerPos = linkedListMap.First();
            Thread.Sleep(2000);
            Console.WriteLine("몬스터들을 해치우며 골에 도착하면 당신의 승리입니다");
            goalPos = linkedListMap.Last();


        }
        private void Render()
        {
            
        }

        private void Input()
        {

        }

        private void Update()
        {

        }

        private void End()
        {

        }
    }
}
