using System;
using System.Collections.Generic;
using System.Text;

namespace Pamela_Sibadzija
{
    class Warrior
    {
        // Definisanje svojstva ratnika
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Pravljenje randoma za koriscenje kasnije 
        Random rnd = new Random();

        // Konstruktor inicijalizuje ratnika
        public Warrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        // Generisanje random napada od 1 do maksimalnog napada ratnika
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        // Generisanje random blokiranja od 1 do maksimalnog bloka ratnika
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
