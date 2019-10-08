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
            int retry = 0;


            while (retry == 0)
            {
                Fighter playerOne = new Fighter();
                Fighter playerTwo = new Fighter();

                Console.WriteLine("Namnge de två kämparna");
                Console.Write("Kämpe 1: ");
                playerOne.FighterName();
                Console.Write("Kämpe 2: ");
                playerTwo.FighterName();
                Console.Clear();
                Console.ReadKey();
                Console.WriteLine("Nu börjar striden!");
                Console.ReadKey();

                while (playerOne.isAlive() == true && playerTwo.isAlive() == true)
                {                

                    int h1 = playerOne.Attack();
                    playerTwo.Hurt(h1);
                    Console.ReadKey();

                    playerTwo.GetHp();
                    playerTwo.isAlive();

                    int h2 = playerTwo.Attack();
                    playerOne.Hurt(h2);
                    Console.ReadKey();

                    playerOne.GetHp();
                    playerOne.isAlive();

                }

                if (playerOne.isAlive() == true && playerTwo.isAlive() == false)
                {
                    playerOne.FighterName();
                }
                else if (playerOne.isAlive() == false && playerTwo.isAlive() == true)
                {
                    playerTwo.FighterName();
                }

                Console.WriteLine("Vill du köra igen (ja/nej) ?");
                Console.Write("Svar: ");

                string answer = Console.ReadLine().ToLower();

                while (answer != "ja" && answer != "nej")
                {
                    Console.WriteLine("Skriv ett giltigt svar (ja/nej)");
                    answer = Console.ReadLine().ToLower();
                }

                if (answer == "ja")
                {
                    Console.Clear();
                    retry = 0;

                }

                else if (answer == "nej")
                {
                    retry = 1;
                }

            }

        }
    }
}
