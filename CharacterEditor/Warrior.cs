using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterEditor
{
    class Warrior: Unit
    {
        public Warrior(double str, double dex, double con, double intl)
        {
            Str = str;
            Dex = dex;
            Con = con;
            Intl = intl;
        }

        public override double Str
        {
            get => base.Str;
            set
            {
                if (value >= 30 & value <= 250)
                {
                    base.Str = value;
                }
                else if (value < 30)
                {
                    base.Str = 30;
                }
                else if (value > 250)
                {
                    base.Str = 250;
                }
            }
        }

        public override double Dex
        {
            get => base.Dex;
            set
            {
                if (value >= 15 & value <= 80)
                {
                    base.Dex = value;
                }
                else if (value < 15)
                {
                    base.Dex = 15;
                }
                else if (value > 80)
                {
                    base.Dex = 80;
                }
            }
        }

        public override double Con
        {
            get => base.Con;
            set
            {
                if (value >= 25 & value <= 100)
                {
                    base.Con = value;
                }
                else if (value < 25)
                {
                    base.Con = 25;
                }
                else if (value > 100)
                {
                    base.Con = 100;
                }
            }
        }

        public override double Intl
        {
            get => base.Intl;
            set
            {
                if (value >= 10 & value <= 50)
                {
                    base.Intl = value;
                }
                else if (value < 10)
                {
                    base.Intl = 10;
                }
                else if (value > 50)
                {
                    base.Intl = 50;
                }
            }
        }

        public double PDamage
        {
            get
            {
                double buffer = 0;
                buffer += Str * 7;
                buffer += Dex * 2;

                return buffer;
            }

        }

        public double PDefence
        {
            get
            {
                double buffer = 0;
                buffer += Str * 2;
                buffer += Dex * 3;
                buffer += Con * 3;
                return buffer;
            }

        }

        public double MDamage
        {
            get
            {
                double buffer = 0;
                buffer += Intl * 1;
                return buffer;
            }

        }

        public double MDefence
        {
            get
            {
                double buffer = 0;
                buffer += Str * 1;
                buffer += Intl * 2;
                buffer += Con * 1;
                return buffer;
            }

        }

        public double Health
        {
            get
            {
                double buffer = 0;
                buffer += Str * 5;
                buffer += Con * 10;
                return buffer;
            }

        }

        public double Magic
        {
            get
            {
                double buffer = 0;
                buffer += Intl * 1;
                return buffer;
            }

        }



    }
}
