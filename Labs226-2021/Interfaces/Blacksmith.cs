using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Interfaces
{
    class Blacksmith
    {
        public StoneAxe CraftStoneAxe()
        {
            return new StoneAxe();
        }

        public IronSword CraftIronSword()
        {
            return new IronSword();
        }
        public LightCrossbow CraftLightCrossbow()
        {
            return new LightCrossbow();
        }

        public void RepairItem(IRepairible item)
        {
            item.durability += 10;
        }
        
    }
}
