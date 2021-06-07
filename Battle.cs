using System;
using System.Collections.Generic;
using System.Text;

namespace Pamela_Sibadzija
{
        class Battle
        {
            // Pocetak borbe
            public static void StartFight(Warrior warrior1,
                Warrior warrior2)
            {
                // Loop daje oba ratnika sansu da napadnu i blokiraju makar jednom
                while (true)
                {
                    if (GetAttackResult(warrior1, warrior2) == "Game Over")
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }

                    if (GetAttackResult(warrior2, warrior1) == "Game Over")
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
            }

            // Prihvata oba ratnika
            public static string GetAttackResult(Warrior warriorA,
                Warrior warriorB)
            {
                // Racuna napad jednog i blok drugog
                double warA = warriorA.Attack();
                double warB = warriorB.Block();

                // Oduzima blok od napada
                double dmg2WarB = warA - warB;

                // Ako je bilo stete oduzima je od Healtha
                if (dmg2WarB > 0)
                {
                    warriorB.Health = warriorB.Health - dmg2WarB;
                }
                else dmg2WarB = 0;

                // Stampa info o tome ko je napao i koliko je damagea dao
                Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                    warriorA.Name,
                    warriorB.Name,
                    dmg2WarB);

                // Pravi outpot na stanje healtha napadnutog
                Console.WriteLine("{0} Has {1} Health\n",
                    warriorB.Name,
                    warriorB.Health);

                // Proverava da li je ratnik pao ispod nule i ako jeste prekida loop
                if (warriorB.Health <= 0)
                {
                    Console.WriteLine("{0} has Died and {1} is Victorious\n",
                        warriorB.Name,
                        warriorA.Name);

                    return "Game Over";
                }
                else return "Fight Again";
            }

        }
}
