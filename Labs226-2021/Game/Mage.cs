using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Mage: Unit
    {
        public Mage(int str, int dex, int con, int intl)
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
                if (value < 45 & value > 15)
                {
                    base.Str = value;
                }
                else if (value < 15)
                {
                    base.Str = 15;
                }
                else
                {
                    base.Str = 45;
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
                if (value < 45 & value > 20)
                {
                    base.Dex = value;
                }
                else if (value < 20)
                {
                    base.Dex = 20;
                }
                else
                {
                    base.Dex = 45;
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
                if (value < 250 & value > 35)
                {
                    base.Intl = value;
                }
                else if (value < 35)
                {
                    base.Intl = 35;
                }
                else
                {
                    base.Intl = 250;
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
                if (value < 70 & value > 15)
                {
                    base.Con = value;
                }
                else if (value < 15)
                {
                    base.Con = 15;
                }
                else
                {
                    base.Con = 70;
                }
            }


        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

    }
}
