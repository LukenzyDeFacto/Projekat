using System;

namespace Pamela_Sibadzija
{
    class Program
    {
        /*
        Bob Attacks Maximus and Deals 74 Damage
        Maximus Has 69 Health
 
        Maximus Attacks Bob and Deals 6 Damage
        Bob Has 6 Health
 
        Bob Attacks Maximus and Deals 48 Damage
        Maximus Has 21 Health
 
        Maximus Attacks Bob and Deals 48 Damage
        Bob Has -42 Health
 
        Bob has Died and Maximus is Victorious
 
        Game Over
        */

        static void Main(string[] args)
        {
            Warrior Pamela = new Warrior("Pamela", 1000, 120, 40);
            Warrior Vojska39 = new Warrior("Vojska 3/9", 1000, 120, 40);

            Battle.StartFight(Pamela, Vojska39);

            Console.ReadLine();

        }
    }
}
