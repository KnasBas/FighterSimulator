using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slagsmål.Klasser
{
    class Fighter2 : Fighter
    {
        public new void SetHP()
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

                Random nameGen = new Random();

                int i = nameGen.Next(4);

                name = names[i];

                //name = Console.ReadLine();
                //Console.WriteLine("Du namngav kämpen till " + name);

                Console.WriteLine("Kämpen som du möter heter " + name);

                Random generator = new Random();

                armour = generator.Next(5, 11); //slumpa mellan 0 - 10

                Console.WriteLine("Denna kämpen börjar med " + armour + " armour");

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
