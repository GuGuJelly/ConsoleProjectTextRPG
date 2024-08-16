using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TextRPG_RogueLike.SceneFolder;



namespace TextRPG_RogueLike
{
    public class Game
    {
        private bool isRunning;
        private MapScene mapScene;
        private SceneType playerPos;
        public SceneType goalPos;
        public Monster monster;
        private Scene[] scenes;
        private Scene curScene;
        private Scene prevScene;
        public Scene CurScene { get { return curScene; } }
        private Player player;
        public Player Player { get { return player; } set { player = value; } }
        public MonsterFactory OrcFactory = new MonsterFactory();
        public MonsterFactory SlimeFactory = new MonsterFactory();
        public MonsterFactory RatManFactory = new MonsterFactory();
        public Slash slash;
        public FireBall fireBall;
        public Guard guard;
        public Heal heal;
        public IceShield iceShield;
        public Skill skill;
        
        
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

        public void Over()
        {
            isRunning = false;
        }

        public void Start()
        {
            isRunning = true;

            scenes = new Scene[(int)SceneType.Size];
            scenes[(int)SceneType.Title] = new TitleScene(this);
            scenes[(int)SceneType.Select] = new SelectScene(this);
            scenes[(int)SceneType.Inventory] = new InventoryScene(this);
            scenes[(int)SceneType.SafeHouse] = new SafeHouseScene(this);
            scenes[(int)SceneType.Shop] = new ShopScene(this);
            scenes[(int)SceneType.MonsterRoom] = new MonsterRoomScene(this);
            scenes[(int)SceneType.BossMonsterRoom] = new BossMonsterRoomScene(this);
            scenes[(int)SceneType.Goal] = new GoalScene(this);
            scenes[(int)SceneType.Battle] = new BattleScene(this);  

            player = new Player();
            Skill skill = new Skill();
            slash = new Slash();
            fireBall = new FireBall();
            heal = new Heal();
            iceShield = new IceShield();
            guard = new Guard();


            curScene = scenes[(int)SceneType.Title];
            CurScene.Enter();
        }

        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void ReturnScene()
        {
            curScene.Exit();
            curScene = prevScene;
            curScene.Enter();
        }
        private void Render()
        {
            curScene.Render();
        }

        private void Input()
        {
            curScene.Input();
        }

        private void Update()
        {
            curScene.Update();
        }

        private void End()
        {
            curScene.Update();
        }
    }
}
