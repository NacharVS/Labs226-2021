using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
{
    class Healer : Unit
    {
        private int _Healing;

        public int Healing { get => _Healing; set => _Healing = value; }
    }
}
