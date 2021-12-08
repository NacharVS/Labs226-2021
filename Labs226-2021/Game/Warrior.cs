using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Warrior : Unit
    {

        public Warrior(int str, int dex, int con, int intl)
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
                if (value < 250 & value > 30)
                {
                    base.Str = value;
                }
                else if (value < 30)
                {
                    base.Str = 30;
                }
                else
                {
                    base.Str = 250;
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
                if (value < 80 & value > 20)
                {
                    base.Dex = value;
                }
                else if (value < 20)
                {
                    base.Dex = 20;
                }
                else
                {
                    base.Dex = 80;
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
                if (value < 50 & value > 35)
                {
                    base.Intl = value;
                }
                else if (value < 35)
                {
                    base.Intl = 35;
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
                if (value < 100 & value > 25)
                {
                    base.Con = value;
                }
                else if (value < 25)
                {
                    base.Con = 25;
                }
                else
                {
                    base.Con = 100;
                }
            }


        }





        public override void ShowInfo() {base.ShowInfo();}

    }
}
