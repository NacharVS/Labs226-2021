using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Rogue: Unit 
    {
        public Rogue(int str, int dex, int con, int intl)
        {
            base.Str = str;
            base.Dex = dex;
            base.Con = con;
            base.Intl = intl;
        }
    }
}
