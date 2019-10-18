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
                playerOne.FighterName(); //Klass metoden körs och därmed namnger kämpen
                playerTwo.FighterName(); //Här körs FighterName från Fighter2 som använder en slumpgenerator för namnen
                Console.Clear();
                Console.WriteLine("Nu börjar striden!");
                Console.ReadKey();

                while (playerOne.isAlive() == true && playerTwo.isAlive() == true) //While-loopen som håller striden igång med deras metoder som körs tills den ena dör.
                {
                    int h1 = playerOne.Attack(); //Attack metoden lagras
                    playerTwo.Hurt(h1); //h1 lagrar värdet från Attack och används inom Hurt för att göra rätt mängd damage
                    Console.ReadKey();
                    playerTwo.GetHp();
                    if (!playerTwo.isAlive()) break; //Break:en används eftersom ifall bool:en är false måste while-loopen avbrytas
                    ///////////////////
                    int h2 = playerTwo.Attack(); //Samma principer som innan
                    playerOne.Hurt(h2); //Samma principer som innan
                    Console.ReadKey();
                    playerOne.GetHp(); //Samma principer som innan
                    if (!playerOne.isAlive()) break; //Samma principer som innan                         
                }

                if (playerOne.isAlive() == true && playerTwo.isAlive() == false) //Här testats argument för vinnaren, här vinner PlayerOne
                {
                    playerOne.FighterName(); //FighterName har nu uppdaterats efter första gången den kördes och skriver ut vinnaren.
                }
                else if (playerOne.isAlive() == false && playerTwo.isAlive() == true) //Här vinner PlayerTwo
                {
                    playerTwo.FighterName(); // -||-
                }

                Console.WriteLine("Vill du köra igen (ja/nej) ?"); //Frågar ifall man vill spela igen
                Console.Write("Svar: ");

                string answer = Console.ReadLine().ToLower(); //ToLower för felsökning

                while (answer != "ja" && answer != "nej") //Felsökning
                {
                    Console.WriteLine("Skriv ett giltigt svar (ja/nej)");
                    answer = Console.ReadLine().ToLower();
                }

                if (answer == "ja") //enkla if-satser för att se om kravet uppfylls för att starta om spelet
                {
                    Console.Clear();
                    retry = 0;

                }

                else if (answer == "nej")
                {
                    retry = 1; //retry uppdateras och spelet avslutas
                }

                /* bool playerOneisAlive = playerOne.isAlive();

                bool playerTwoisAlive = playerTwo.isAlive();

                while(playerOneisAlive == true && playerTwoisAlive == true)
                {
                    playerTwoisAlive = playerTwo.isAlive();
                    int h1 = playerOne.Attack(); //Attack metoden lagras
                    playerTwo.Hurt(h1);
                    Console.ReadKey();
                    playerTwo.GetHp();
                    playerTwoisAlive = playerTwo.isAlive();

                    playerOneisAlive = playerOne.isAlive();
                    int h2 = playerTwo.Attack(); //Samma principer som innan
                    playerOne.Hurt(h2); //Samma principer som innan
                    Console.ReadKey();
                    playerOne.GetHp();
                    playerOneisAlive = playerOne.isAlive();
                }*/

            }

        }
    }
}
