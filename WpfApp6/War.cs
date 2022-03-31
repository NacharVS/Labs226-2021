using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp6
{
    class War : units
    {
        [BsonIgnoreIfDefault] public ObjectId _id { get; set; }
        public string login;

        
        public War(string login, int lvl, int xp, int Pts, int con, int dex, int _int, int str)
        {
            this.login = login;
            Lvl = lvl;
            Xp = xp;
            pts = Pts;
            _lvlcon = con;
            _lvldex = dex;
            _lvlint = _int;
            _lvlstr = str;
        }

        public double Healh
        {
            get => _healh = 30 + (5 * _lvlstr) + (0 * _lvldex) + (0 * _lvlint) + (10 * _lvlcon);
            set
            {
                _healh = 30 + (5 * _lvlstr) + (0 * _lvldex) + (0 * _lvlint) + (10 * _lvlcon);
            }
        }

        public int str
        {
            get => _str = 30;
            set
            {

                _str = 30;
            }
        }
        public int dex
        {
            get => _dex = 15;
            set
            {

                _dex = 15;
            }
        }
        public int intel
        {
            get => _int = 10;
            set
            {
                _int = 10;
            }
        }
        public int con
        {
            get => _con = 25;
            set
            {
                _con = 25;
            }
        }
        public int fizdamage
        {
            get => _fizdamage = _str + (7 * _lvlstr) + (2 * _lvldex) + (0 * _lvlint) + (0 * _lvlcon);
            set
            {
                _fizdamage = _str + (7 * _lvlstr) + (2 * _lvldex) + (0 * _lvlint) + (0 * _lvlcon);
            }
        }
        public int fizdef
        {
            get => _fizdef = 10 + (2 * _lvlstr) + (3 * _lvldex) + (0 * _lvlint) + (3 * _lvlcon);
            set
            {
                _fizdef = 10 + (2 * _lvlstr) + (3 * _lvldex) + (0 * _lvlint) + (3 * _lvlcon);
            }
        }
        public int ratmirdef
        {
            get => _ratmirdef = 15 + (1 * _lvlstr) + (0 * _lvldex) + (2 * _lvlint) + (1 * _lvlcon);
            set
            {
                _ratmirdef = 15 + (1 * _lvlstr) + (0 * _lvldex) + (2 * _lvlint) + (1 * _lvlcon);
            }
        }
        public int ratmirdamage
        {
            get => _ratmirdamage = 5 + (0 * _lvlstr) + (0 * _lvldex) + (1 * _lvlint) + (0 * _lvlcon);
            set
            {
                _ratmirdamage = 5 + (0 * _lvlstr) + (0 * _lvldex) + (1 * _lvlint) + (0 * _lvlcon);
            }
        }
        public int ratmir
        {
            get => _ratmir = _int + (0 * _lvlstr) + (0 * _lvldex) + (1 * _lvlint) + (0 * _lvlcon);
            set
            {
                _ratmir = _int + (0 * _lvlstr) + (0 * _lvldex) + (1 * _lvlint) + (0 * _lvlcon);
            }
        }
        
    }
    }


