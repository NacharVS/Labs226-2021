using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    interface Blacksmith
    {
        public void RepairItem(IRepairible item)
        {
            item.durability += 10;
        }
        public IronSword CraftIronSword()
        {
            return new IronSword();
        }
        public StoneAxe CraftStoneAxe()
        {
            return new StoneAxe();
        }
        public Bow CraftBow()
        {
            return new Bow();
        }
    }
}
