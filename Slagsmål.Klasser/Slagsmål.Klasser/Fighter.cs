using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slagsmål.Klasser
{
    class Fighter
    {
        private int hp = 100;

        public string name = "";

        private int End = 0;

        /*public Fighter(string name)
        {
            name = Console.ReadLine();
            Console.WriteLine("Du namngav kämpen till " + name);
        }*/

        public void FighterName()
        {
            End++;
            if (End == 1)
            {
                name = Console.ReadLine();
                Console.WriteLine("Du namngav kämpen till " + name);
            }
            else
            {
                Console.WriteLine(name + "vann!" );
            }
            
        }                  
        public int Attack()
        {
            Random generator = new Random();

            int damage = generator.Next(10, 21);

            return damage;
        }

        public void Hurt(int amount)
        {
            Console.WriteLine(name + "tog " + amount + " skada och har nu " + hp + "hp kvar.");
            hp = hp - amount;
        }

        public bool isAlive()
        {
            bool Alive = false;

            if (hp <= 1)
            {
                Alive = true;
            }
            else
            {
                Alive = false;
            }

            return Alive;
        }
        
        public int GetHp()
        {
            Console.WriteLine(hp);
            return hp;
        }
    }
}
