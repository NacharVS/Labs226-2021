using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Strategy
<<<<<<< HEAD
{ }
    //class Healer : Unit
    //{
    //    public Healer(string type, int max, int health, int healet, int min)
    //    {
    //        base.Name = type;
    //        base.Min = min;
    //        base.Max = max;
    //        base.Hp = health;
    //        base.Healt = healet;
    //    }
    //    public void Healing()
    //    {

    //        Console.WriteLine($"{Name} delivered {Healt} heal" + $"{Hp} healthpoint");
    //        Hp += Healt;
    //        Console.WriteLine($"Current healthpoint {Hp}");
    //        Console.WriteLine();
    //    }

    //}
=======
{
    class Healer : Unit
    {
        private int _Healing;

        public int Healing { get => _Healing; set => value = Health + 15; }
    }
}
>>>>>>> 7dc46896327904c8f11eb3eca1b17fb64a241b66
