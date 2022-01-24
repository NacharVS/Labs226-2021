using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.shema
{
    class Archer : Moveble
    {

        public Archer() : base("Archer", 20, 7, 2)
        {

        }






        public void Shooting(Archer shoting, Archer accepted)
        {
            while (shoting.health > 0 && accepted.health > 0)
            {
                if (shoting.health != 0)
                {
                    Console.WriteLine($"{shoting.type} is shooting and delivery damage {shoting.damage} to {accepted.type}");
                    accepted.health = accepted.health - shoting.damage;
                   
                }
                else
                {

                    Console.WriteLine($"{shoting.type} dide");
                }
               
                shoting.Info();
                accepted.Info();
                if (accepted.health != 0)
                {
                    Console.WriteLine($"{accepted.type} is shooting and delivery damage {accepted.damage} to {shoting.type}");
                    shoting.health = shoting.health - accepted.damage;
                }
                else 
                { 
      
                    Console.WriteLine($"{accepted.type} dide");
                }
            
           
               
               
            }
        } }
}
