using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public enum SceneType { Title, Select, Inventory, SafeHouse, Shop, Battle, MonsterRoom, BossMonsterRoom, Goal, Map, Size }
    
    public enum SkillList { FireBall, IceShield, Heal, Slash, Guard, Size }
    public enum SkillBook { FireBall, IceShield, Heal }
    public enum MonsterType { Dummy, Slime, Orc, RatMan, BigSlime, OrcKing }
    public enum ItemType { ShortSword, RoundShield, LongSword, TowerShield, AllPotion, Gold }
}
