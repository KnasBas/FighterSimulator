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

        private int amount = 0;

        public int Attack()
        {
            Random generator = new Random();

            int damage = generator.Next(10, 21);

            amount = damage;

            return amount;
        }

        public void Hurt(int amount)
        {
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
