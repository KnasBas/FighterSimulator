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

        public void FighterName()
        {
            if (End == 1)
            {
                Console.WriteLine(name + " vann!");
                Console.WriteLine("Grattis!");
            }
            else
            {
                name = Console.ReadLine();
                Console.WriteLine("Du namngav kämpen till " + name);
                End++;
            }        
        }                  
        public int Attack()
        {
            Random generator = new Random();

            int damage = generator.Next(10, 26);

            return damage;
        }

        public void Hurt(int amount)
        {
            hp = hp - amount;

            if (hp < 0)
            {
                hp = 0;
            }

            Console.WriteLine(name + " tog " + amount + " skada och har nu " + hp + "hp kvar.");
        }

        public bool isAlive()
        {
            bool Alive = false;

            if (hp >= 1)
            {
                Alive = true;
            }
            else if (hp <= 0) 
            {
                Alive = false;
            }

            return Alive;
        }
        
        public int GetHp()
        {
            return hp;
        }
    }
}
