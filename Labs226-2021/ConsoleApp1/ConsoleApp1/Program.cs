using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{class Character
    {
        public int Str;
        public int Dex;
        public int Int;
        public int Con;
        public int Attack;
        public int Defence;

        public void Warrior(int Str, int dex, int Int, int Con)
        {
            this.Str = Str;
            if (Str < 30)
            { 
                Str = 30;
                Console.WriteLine($"Ты слаб...");

            }
            else if (Str > 250)
                {
                    Str = 250;
                Console.WriteLine($"Такой сильный что даже маму свою поднимешь, сори разраб максимум прописал");
                }
            this.Dex = dex;
            if (dex < 15)
            {               
             dex = 15;
                Console.WriteLine($"Теперь ты уволень, сори конечно но разраб задал миниимальное значение и оно больше того которое ты хочешь, у тебя {dex} ловкости");
            }
            else if (dex > 80)
            {
                dex = 80;
                Console.WriteLine($"где такое видано чтобы танк от крысы подыхал, лучше у тебя будет {Con} Защиты");
            }
            this.Int = Int;
            if (Int < 10)
            {
               
             Int = 10;
                Console.WriteLine($"Настолько туп чтобы держать оружие... Не так не пойдёт, {Int} интеллекта тебе и твоему сыну");
            }
            else if (Int > 35)
            {
             Int = 35;
             Console.WriteLine($"Дофига умный? Воин не может иметь ученую степень, его удел махать мечом, возвращено к максимуму в {Int}");
            }
            this.Con = Con;
            if (Con < 25)
            {    
             Con = 25;
                Console.WriteLine($"где такое видано чтобы танк от крысы подыхал, лучше у тебя будет {Con} Защиты");
            }
            else if (Con > 100)
            {
             Con = 100;
                Console.WriteLine($"Ах ты читераст, Возвращено к максимальному {Con}");
            }
            double PAttack = Str * 0.2 + dex * 0.2;
            double PDefence = dex * 0.1 + Con * 0.2;
            double MAttack = Int * 0.2 + Int / 10;
            double MDefence = Int * 0.3;

        }
        public void Mage(int Str, int dex, int Int, int Con)
        {
            this.Str = Str;
            if (Str < 30)
            {
                Str = 30;
                Console.WriteLine($"Ты слаб...");

            }
            else if (Str > 250)
            {
                Str = 250;
                Console.WriteLine($"Такой сильный что даже маму свою поднимешь, сори разраб максимум прописал");
            }
            this.Dex = dex;
            if (dex < 15)
            {
                dex = 15;
                Console.WriteLine($"Теперь ты уволень, сори конечно но разраб задал миниимальное значение и оно больше того которое ты хочешь, у тебя {dex} ловкости");
            }
            else if (dex > 80)
            {
                dex = 80;
                Console.WriteLine($"маг стоит и кастует а не вертится от ударов");
            }
            this.Int = Int;
            if (Int < 35)
            {

                Int = 35;
                Console.WriteLine($"Настолько туп чтобы держать оружие... Не так не пойдёт, {Int} интеллекта тебе и твоему сыну");
            }
            else if (Int > 250)
            {
                Int = 35;
                Console.WriteLine($"Дофига умный? Воин не может иметь ученую степень, его удел махать мечом, возвращено к максимуму в {Int}");
            }
            this.Con = Con;
            if (Con < 25)
            {
                Con = 25;
                Console.WriteLine($"где такое видано чтобы танк от крысы подыхал, лучше у тебя будет {Con} Защиты");
            }
            else if (Con > 100)
            {
                Con = 100;
                Console.WriteLine($"Ах ты читераст, Возвращено к максимальному {Con}");
            }
            double PAttack = Str * 0.2 + dex * 0.2;
            double PDefence = dex * 0.1 + Con * 0.2;
            double MAttack = Int * 0.2 + Int / 10;
            double MDefence = Int * 0.3;

        }
        public void Archer(int Str, int dex, int Int, int Con)
        {
            this.Str = Str;
            if (Str < 30)
            {
                Str = 30;
                Console.WriteLine($"Ты слаб...");

            }
            else if (Str > 250)
            {
                Str = 250;
                Console.WriteLine($"Такой сильный что даже маму свою поднимешь, сори разраб максимум прописал");
            }
            this.Dex = dex;
            if (dex < 15)
            {
                dex = 15;
                Console.WriteLine($"Теперь ты уволень, сори конечно но разраб задал миниимальное значение и оно больше того которое ты хочешь, у тебя {dex} ловкости");
            }
            else if (dex > 80)
            {
                dex = 80;
                Console.WriteLine($"где такое видано чтобы танк от крысы подыхал, лучше у тебя будет {Con} Защиты");
            }
            this.Int = Int;
            if (Int < 10)
            {

                Int = 10;
                Console.WriteLine($"Настолько туп чтобы держать оружие... Не так не пойдёт, {Int} интеллекта тебе и твоему сыну");
            }
            else if (Int > 35)
            {
                Int = 35;
                Console.WriteLine($"Дофига умный? Воин не может иметь ученую степень, его удел махать мечом, возвращено к максимуму в {Int}");
            }
            this.Con = Con;
            if (Con < 25)
            {
                Con = 25;
                Console.WriteLine($"где такое видано чтобы танк от крысы подыхал, лучше у тебя будет {Con} Защиты");
            }
            else if (Con > 100)
            {
                Con = 100;
                Console.WriteLine($"Ах ты читераст, Возвращено к максимальному {Con}");
            }
            double PAttack = Str * 0.2 + dex * 0.2;
            double PDefence = dex * 0.1 + Con * 0.2;
            double MAttack = Int * 0.2 + Int / 10;
            double MDefence = Int * 0.3;

        }
    }


  
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

}
//public double Health = 1.5 * con + 0.5 *.str;
//public int = 2 * int;
//public double W_Atk = W_str * 0.2 + W_dex * 0.2;
//public double W_Def = W_dex * 0.1 + W_Con * 0.2;