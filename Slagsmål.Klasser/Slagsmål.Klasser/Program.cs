using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slagsmål.Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter player1 = new Fighter();
            Fighter player2 = new Fighter();

            Console.WriteLine("Namnge de två kämparna");
            Console.ReadKey();
            Console.WriteLine("Kämpe 1");
            player1.FighterName();
            Console.WriteLine("Kämpe 2");
            player2.FighterName();
            Console.ReadKey();
            Console.WriteLine("Nu börjar striden!");
            Console.ReadKey();

            while (player1.isAlive() == true && player2.isAlive() == true)
            {
                int h1 = player1.Attack();
                player2.Hurt(h1);
                player2.GetHp();
                player2.isAlive();

                int h2 = player2.Attack();
                player1.Hurt(h2);
                player1.GetHp();
                player1.isAlive();                
            }

            if (player1.isAlive() == true && player2.isAlive() == false)
            {
                player1.FighterName();
            }
            else
            {
                player2.FighterName();
            }
        }
    }
}
