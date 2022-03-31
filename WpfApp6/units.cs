using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp6
{
    class units
    {
        public int _str;
        public int _dex;
        public int _int;
        public int _con;
        public int _fizdamage;
        public int _fizdef;
        public int _ratmirdamage;
        public int _ratmirdef;
        public int _healh;
        public int _ratmir;
        public int _lvl;
        public int _lvlstr;
        public int _lvldex;
        public int _lvlint;
        public int _lvlcon;
        public int Xp;
        public int _pts;
        public int pts
        {
            get
            {
                if (Lvl == 2)
                {
                    _pts = 5;
                }

                if (Lvl == 3)
                {
                    _pts += 5;
                }

                if (Lvl == 4)
                {
                    _pts += 5;
                }

                if (Lvl == 5)
                {
                    _pts += 5;
                }

                if (Lvl == 6)
                {
                    _pts += 5;
                }
                return _pts;
            }
            set
            {
                if (Lvl == 2)
                {
                    _pts += 5;
                }

                if (Lvl == 3)
                {
                    _pts += 5;
                }

                if (Lvl == 4)
                {
                    _pts += 5;
                }

                if (Lvl == 5)
                {
                    _pts += 5;
                }

                if (Lvl == 6)
                {
                    _pts += 5;
                }

            }

        }

        public int Lvl
        {
            get
            {
                if (Xp < 1000)
                {

                    _lvl = 1;
                }
                if (Xp >= 1000)
                {
                    _lvl = 2;
                  
                }
                if (Xp >= 3000)
                {
                    _lvl = 3;
                 
                }
                if (Xp >= 6000)
                {
                    _lvl = 4;
                   
                }
                if (Xp >= 10000)
                {
                    _lvl = 5;
                   
                }
                if (Xp >= 15000)
                {
                    _lvl = 6;
                   
                }
                return _lvl;
              
            }
            set
            {
                if (Xp >= 1000)
                {
                    _lvl = 2;
                    
                }
                if (Xp >= 3000)
                {
                    _lvl = 3;
                }
                if (Xp >= 6000)
                {
                    _lvl = 4;
                    
                }
                if (Xp >= 10000)
                {
                    _lvl = 5;
                   
                }
                if (Xp >= 15000)
                {
                   
                    _lvl = 6;
                }
            }
        }
           
        }
    }

