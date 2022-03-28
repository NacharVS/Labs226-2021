using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterEditor
{
    class CountingCharacteristics
    {
        private static int _minBonus = 0;
        private int _startedBonus;
    

        public int StartedBonus
        {
            get => _startedBonus;

            set 
            {
                if (value < _minBonus)
                    _startedBonus = value;
                else
                    _startedBonus = value;
            }
        }



    }
}
