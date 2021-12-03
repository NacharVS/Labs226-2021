//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Labs226_2021.Strategy
//{
//    class Healer : Unit
//    {
//        public Healer(string type, int mindamage, int maxdamage, int speed, int hp, int aspeed, string located)
//        {
//            base.TypeUnit = type;
//            base.Mindamage = mindamage;
//            base.Maxdamage = maxdamage;
//            base.Speed = speed;
//            base.CurrentHealth = hp;
//            base.AttackSpeed = aspeed;
//            base.Located = located;
//        }

//        public void Produce()
//        {
//            Console.WriteLine($"Healer лечит себя...");
//        }

//        public void CancelAction()
//        {
//            Console.WriteLine($"Healer закончил себя лечить...");
//        }
//    }
//}
