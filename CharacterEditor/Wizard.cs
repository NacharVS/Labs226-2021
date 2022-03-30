namespace CharacterEditor
{
    class Wizard: Unit
    {
        public Wizard(double str, double dex, double con, double intl)
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
                if (value >= 15 & value <= 45)
                {
                    base.Str = value;
                }
                else if (value < 15)
                {
                    base.Str = 15;
                }
                else if (value > 45)
                {
                    base.Str = 45;
                }
            }
        }

        public override double Dex
        {
            get => base.Dex;
            set
            {
                if (value >= 20 & value <= 70)
                {
                    base.Dex = value;
                }
                else if (value < 20)
                {
                    base.Dex = 20;
                }
                else if (value > 70)
                {
                    base.Dex = 70;
                }
            }
        }

        public override double Con
        {
            get => base.Con;
            set
            {
                if (value >= 15 & value <= 65)
                {
                    base.Con = value;
                }
                else if (value < 15)
                {
                    base.Con = 15;
                }
                else if (value > 65)
                {
                    base.Con = 65;
                }
            }
        }

        public override double Intl
        {
            get => base.Intl;
            set
            {
                if (value >= 30 & value <= 250)
                {
                    base.Intl = value;
                }
                else if (value < 30)
                {
                    base.Intl = 30;
                }
                else if (value > 250)
                {
                    base.Intl = 250;
                }
            }
        }

        public double PDamage
        {
            get
            {
                double buffer = 0;
                buffer += Str * 1;
                buffer += Dex * 1;

                return buffer;
            }

        }

        public double PDefence
        {
            get
            {
                double buffer = 0;
                buffer += Str * 1;
                buffer += Dex * 1;
                buffer += Intl * 1;
                buffer += Con * 2;
                return buffer;
            }

        }

        public double MDamage
        {
            get
            {
                double buffer = 0;
                buffer += Intl * 7;
                return buffer;
            }

        }

        public double MDefence
        {
            get
            {
                double buffer = 0;
                buffer += Intl * 5;
                buffer += Con * 1;
                return buffer;
            }

        }

        public double Health
        {
            get
            {
                double buffer = 0;
                buffer += Str * 1;
                buffer += Con * 3;
                return buffer;
            }

        }

        public double Magic
        {
            get
            {
                double buffer = 0;
                buffer += Con * 2;
                return buffer;
            }

        }
    }
}
