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

        protected int End = 0; //Varför jag använder protected istället för private är för att jag vill att Fighter2 klassen ska ärva deras värden

        protected int armour = 0;

        protected int weapon = 0;

        public void FighterName()
        {
            if (End == 1)
            {
                Console.WriteLine(name + " vann!"); //Efter att Fightername har körts en gång så kommer if-satsen att skriva ut vinnaren
                Console.WriteLine("Grattis!");
            }
            else
            {
                name = Console.ReadLine();
                Console.WriteLine("Du namngav kämpen till " + name + " och hen kommer börja med " + hp + "hp");

                Random generator = new Random();
                                                //Generator för armour värdet
                armour = generator.Next(6); //slumpa mellan 0 - 5

                Console.WriteLine("Denna kämpen börjar med " + armour + " armour");

                weapon = generator.Next(3); // 1/3 chans

                if (weapon == 2)
                {
                    Console.WriteLine("Du hade tur och din kämpe startar med ett vapen som gör mer dmg");
                }

                Console.ReadKey();

                End++; //Eftersom att jag enabrt använder Fightername konstruktorn en gång i main så tänkte jag att ifall jag inför en till variabel skulle jag enkelt kunna utnyttja denna för att skriva ut vinnaren i slutet av spelet
            }        
        }         
        public void SetHP() //SetHp är en vanlig slump generator till hp-värdet
        {
            Random generator = new Random();

            hp = generator.Next(150, 201);
        }

        public int Attack() //Attack metoden. 
        {
            Random generator = new Random();
                                                    //En slump generator för att slumpa mängden damage som kämparna ka utföra.
            int damage = generator.Next(10, 26);

            if (weapon == 2) //Notera att ifall min tidigare slump generator för weapon "rullade" en två kommer kämpen att ha tillgång till ett vapen som gör dubbelt med damage
            {
                damage = damage * 2;
            }

            return damage; //returnerar damage till en int parameter i main
        }

        public void Hurt(int amount) //Hurt metoden tar emot värdet från Attack metoden i program.cs (Main)
        {
            amount = amount - armour; //Här införs mitt armour system som minskar skadan kämpen tar emot

            hp = hp - amount; //nu används amount för att minska hp:et (kämpen tar skad)

            if (hp < 0) //If-satsen hindrar hp:et att sjunka under 0
            {
                hp = 0;
            }

            Console.WriteLine(name + " tog " + amount + " skada och har nu " + hp + "hp kvar."); //Hurt metoden skriver även ut hur mkt damage kämpen tog samt hur mkt hen har kvar
        }

        public bool isAlive() //isAlive metoden checkar ifall spelaren är död genom att använda hp int:en
        {
            bool Alive = false;

            if (hp >= 1) //If-sats ifall hp över noll så kommer isAlive skicka true
            {
                Alive = true;
            }

            return Alive;
        }
        
        public int GetHp()
        {
            return hp;
        }
    }
}
