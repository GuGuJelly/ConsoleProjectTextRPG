using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_RogueLike
{
    public class MonsterFactory : Monster
    {
        //public string mName;
        //public MonsterType monsterType;
        //public ItemType itemType;
        //public ItemType dropItem;
        //public int monstermaxHP;
        //public int monstercurHP;
        //public int monstermaxMP;
        //public int monstercurMP;
        //public int monsterAP;
        //public int monsterDP;

        public MonsterFactory() 
        {
            mName = string.Empty;
            monsterType = MonsterType.Orc;
            monstermaxHP = 200;
            monstercurHP = 200;
            monstermaxMP = 10;
            monstercurMP = 10;
            monsterAP = 40;
            monsterDP = 10;
            dropItem = ItemType.Gold;
        }

        public void SetmName(string mName) 
        {
            this.mName = mName;
        }

        public void SetMonsterType(MonsterType monsterType) 
        {
            this.monsterType = monsterType;
        }

        public void SetDropItem(ItemType dropItem) 
        {
            this.dropItem = dropItem;
        }

        public void SetMonstermaxHP(int monstermaxHP)
        {
            this.monstermaxHP = monstermaxHP;
        }

        public void SetMonstercurHP(int monstercurHP)
        {
            this.monstercurHP = monstercurHP;
        }

        public void SetMonstermaxMP(int monstermaxMP)
        {
            this.monstermaxMP = monstermaxMP;
        }

        public void SetMonstercurMP(int monstercurMP)
        {
            this.monstercurMP = monstercurMP;
        }

        public void SetMonsterAP(int monsterAP)
        {
            this.monsterAP = monsterAP;
        }

        public void SetMonsterDP(int monsterDP)
        {
            this.monsterDP = monsterDP;
        }


        //public void SetDropItem(ItemType dropItem)
        //{
        //    this.dropItem = dropItem;
        //}
    }
 }
