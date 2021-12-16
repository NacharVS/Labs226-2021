using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    class Activate : Unit
    {
        public static void Activ()
        {
            Warrior war = new Warrior("Орочимару", 35, 20, 25, 25);
            Wizard mag = new Wizard("Лайт", 25, 10, 15, 30);
            Ranger rog = new Ranger("Мастер Чиф", 30, 15, 25, 15);

            Unit[] array = new Unit[3] { war, mag, rog };

            for (int i = 0; i < array.Length; i++)
            {

                array[i].PAttack = 0;
                array[i].MAttack = 0;
                array[i].PDefence = 0;
                array[i].MDefence = 0;
                array[i].Health = 0;
                array[i].Mana = 0;
                array[i].PAttack = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i].CurrencyHealth = array[i].Health;
            }



            mag.ShowInfo();
            Console.WriteLine();
            war.ShowInfo();
            Console.WriteLine();
            rog.ShowInfo();
            Console.WriteLine();




            // Создание классов
            // Битва
            Console.WriteLine(array[0].CurrencyHealth);
            Console.WriteLine(array[1].PAttack);

            Console.WriteLine(array[0].CurrencyHealth - array[1].PAttack);






        }
    }
}
