using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Div
{
    public class Charter
    {
      
       

        public double _str;
        public double _dex;
        public double _int;
        public double _con;
        public int _lvl;
        public double _mana;
        public double _healing;
        public double _damag;
        public double _def;
        public double _critChanse;
        public double _critdamag;
        public int Lvl
        {
            get => _lvl;
            set
            {
                value = 0;
                _lvl = value;
            }

        }

        public void Lvlup(int lvl)
        {
            if (_lvl != 50)
            {
                if (lvl + _lvl < 50)
                {

                    _lvl += lvl;
                    while (lvl != 0)
                    {
                        _str += _str * 0.1;
                        _dex += _dex * 0.1;
                        _int += _int * 0.1;
                        _con += _con * 0.1;
                        _mana += _mana * 0.1;
                        _healing += _healing * 0.1;
                        _damag += _damag * 0.1;
                        _def += _def * 0.1;
                        _critChanse += _critChanse * 0.1;
                        _critdamag += _critdamag * 0.1;
                        lvl -= 1;
                    }

                }
                else
                {
                    Console.WriteLine("Лимит по лвл");
                }

            }
            else
            {
                Console.WriteLine("Лимит по лвл");
            }

        }
    }

    

}

    




