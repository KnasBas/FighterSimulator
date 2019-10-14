using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slagsmål.Klasser
{
    class Fighter
    {
        protected int hp = 100;

        public string name = "";

        protected int End = 0;

        protected int armour = 0;

        protected int weapon = 0;

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

                Random generator = new Random();

                armour = generator.Next(6); //slumpa mellan 0 - 5

                Console.WriteLine("Denna kämpen börjar med " + armour + " armour");

                weapon = generator.Next(3); // 1/3 chans

                if (weapon == 2)
                {
                    Console.WriteLine("Du hade tur och din kämpe startar med ett vapen som gör mer dmg");
                }

                Console.ReadKey();

                End++;
            }        
        }         
        public void SetHP()
        {
            Random generator = new Random();

            hp = generator.Next(150, 201);
        }

        public int Attack()
        {
            Random generator = new Random();

            int damage = generator.Next(10, 26);

            if (weapon == 2)
            {
                damage = damage * 2;
            }

            return damage;
        }

        public void Hurt(int amount)
        {
            amount = amount - armour;

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
