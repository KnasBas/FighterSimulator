using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slagsmål.Klasser
{
    class Fighter2 : Fighter //Ärver från Fighter
    {
        public new void SetHP() //En ny SetHp med läger hp värden, dock sammar principer
        {
            Random generator = new Random();

            hp = generator.Next(130, 151);
        }
        public new void FighterName()
        {
            if (End == 1)
            {
                Console.WriteLine(name + " vann!");
                Console.WriteLine("Grattis!");
            }
            else
            {
                List<string> names = new List<string> {"Bert", "Benji", "Knas", "Martinis" };

                Random nameGen = new Random(); //Istället för fightsimv1 så införde jag en namn generator som slumpar fram namnet för motståndaren

                int i = nameGen.Next(4); //generator mellan 0-3, samma index som listan names

                name = names[i]; //här får name ett namn av names

                Console.WriteLine("Kämpen som du möter heter " + name);

                Random generator = new Random();

                armour = generator.Next(5, 11); //slumpa mellan 5 - 10, ett högre armour värde än main spelaren

                Console.WriteLine("Denna kämpe börjar med " + armour + " armour och börjar med " + hp + "hp");

                weapon = generator.Next(3); // 1/3 chans

                if (weapon == 2)
                {
                    Console.WriteLine("Du hade otur, kämpen du möter startar med ett vapen som gör mer dmg");
                }

                Console.ReadKey();

                End++;
            }
        }

    }
}
