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
            int retry = 0; //retry int:en används senare i programmet för att spelaren ska kunna välja att starta om eller ej.

            while (retry == 0)
            {
                Fighter playerOne = new Fighter(); //Två lika klasser varav figther 2 ärver från fighter
                Fighter2 playerTwo = new Fighter2();
                playerOne.SetHP();
                playerTwo.SetHP();

                Console.WriteLine("Namnge din kämpe");
                Console.Write("Kämpe 1: ");
                playerOne.FighterName();
                playerTwo.FighterName();
                Console.Clear();
                Console.WriteLine("Nu börjar striden!");
                Console.ReadKey();

                while (playerOne.isAlive() == true && playerTwo.isAlive() == true) //While-loopen som håller striden igång med deras metoder som körs tills den ena dör.
                {
                    int h1 = playerOne.Attack();
                    playerTwo.Hurt(h1);
                    Console.ReadKey();
                    playerTwo.GetHp();
                    if (!playerTwo.isAlive()) break;
                    ///////////////////
                    int h2 = playerTwo.Attack();
                    playerOne.Hurt(h2);
                    Console.ReadKey();
                    playerOne.GetHp();
                    if (!playerOne.isAlive()) break;                                 
                }

                if (playerOne.isAlive() == true && playerTwo.isAlive() == false)
                {
                    playerOne.FighterName();
                }
                else if (playerOne.isAlive() == false && playerTwo.isAlive() == true)
                {
                    playerTwo.FighterName();
                }
                else
                {
                    Console.WriteLine("oavgjort");
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
