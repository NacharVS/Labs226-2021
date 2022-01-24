//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Labs226_2021
//{
//    class Ranger : Unit
//    {

//        public Ranger(string name, int str, int dex, int con, int intl)
//        {
//            Name = name;
//            Str = str;
//            Dex = dex;
//            Con = con;
//            Intl = intl;
//        }

//        public override int Str
//        {
//            get => base.Str;
//            set
//            {
//                if (value >= 20 & value <= 55)
//                {
//                    base.Str = value;
//                }
//                else if (value < 20)
//                {
//                    base.Str = 20;
//                }
//                else if (value > 55)
//                {
//                    base.Str = 55;
//                }
//            }
//        }

//        public override int Dex
//        {
//            get => base.Dex;
//            set
//            {
//                if (value >= 30 & value <= 250)
//                {
//                    base.Dex = value;
//                }
//                else if (value < 30)
//                {
//                    base.Dex = 30;
//                }
//                else if (value > 250)
//                {
//                    base.Dex = 250;
//                }
//            }
//        }

//        public override int Con
//        {
//            get => base.Con;
//            set
//            {
//                if (value >= 20 & value <= 70)
//                {
//                    base.Con = value;
//                }
//                else if (value < 20)
//                {
//                    base.Con = 20;
//                }
//                else if (value > 70)
//                {
//                    base.Con = 70;
//                }
//            }
//        }

//        public override int Intl
//        {
//            get => base.Intl;
//            set
//            {
//                if (value >= 15 & value <= 70)
//                {
//                    base.Intl = value;
//                }
//                else if (value < 15)
//                {
//                    base.Intl = 15;
//                }
//                else if (value > 70)
//                {
//                    base.Intl = 70;
//                }
//            }
//        }

//    }
//}

