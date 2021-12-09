using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Rogue : Unit
    {
        public Rogue(int str, int dex, int con, int intl)
        {
            base.Str = str;
            base.Dex = dex;
            base.Con = con;
            base.Intl = intl;
        }




        public override double Str
        {
            get
            {
                return base.Str;
            }

            set
            {
                if (value < 55 & value > 20)
                {
                    base.Str = value;
                }
                else if (value < 20)
                {
                    base.Str = 20;
                }
                else
                {
                    base.Str = 55;
                }
            }


        }

        public override double Dex
        {
            get
            {
                return base.Dex;
            }

            set
            {
                if (value < 250 & value > 30)
                {
                    base.Dex = value;
                }
                else if (value < 30)
                {
                    base.Dex = 30;
                }
                else
                {
                    base.Dex = 250;
                }
            }


        }

        public override double Intl
        {
            get
            {
                return base.Intl;
            }

            set
            {
                if (value < 50 & value > 15)
                {
                    base.Intl = value;
                }
                else if (value < 15)
                {
                    base.Intl = 15;
                }
                else
                {
                    base.Intl = 50;
                }
            }


        }

        public override double Con
        {
            get
            {
                return base.Con;
            }

            set
            {
                if (value < 100 & value > 20)
                {
                    base.Con = value;
                }
                else if (value < 20)
                {
                    base.Con = 20;
                }
                else
                {
                    base.Con = 100;
                }
            }


        }

        public override void ShowInfo() { base.ShowInfo(); }
        public override double Health() { return base.Health(); }

    }
}





