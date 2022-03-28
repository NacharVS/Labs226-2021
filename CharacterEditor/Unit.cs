using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterEditor
{
    class Unit
    {
        private double _str;
        private double _dex;
        private double _con;
        private double _intl;

        private int _mana;

        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicAttack;
        private int _magicDefence;

        private int _pCriticalChange;
        private int _mCriticalChange;
        private int _pCriticalDamage;
        private int _mCriticalDamage;

        

        public virtual double Str
        {
            get => _str;
            set => _str = value;
        }
        public virtual double Dex { get => _dex; set => _dex = value; }
        public virtual double Con { get => _con; set => _con = value; }
        public virtual double Intl { get => _intl; set => _intl = value; }


        


    }
}
