using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Statistics
    {
        public void PrintStats(IProffesion prof)
        {
            if (prof is Warrior)
            {
                Console.WriteLine("Warrior");
            }
            else if (prof is Hunter)
            {
                Console.WriteLine("Hunter");
            }
            else
                Console.WriteLine("Magician");

            Console.WriteLine("Strength: " + prof.Strength);
            Console.WriteLine("Cleverness: " + prof.Cleverness);
            Console.WriteLine("Intelligence: " + prof.Intelligence);
            Console.WriteLine("Luck: " + prof.Luck);
            Console.WriteLine("HP: " + prof.HealthPoints);
        }

        public void MonsterStats(IMonster monster)
        {
            if (monster is Goblin)
            {
                Console.WriteLine("Goblin");
            }
            else if (monster is GoblinChief)
            {
                Console.WriteLine("Gobin Chief");
            }
            else
                Console.WriteLine("Demon");

            Console.WriteLine("Level: " + monster.Level);
            Console.WriteLine("Strength: " + monster.Strength);
            Console.WriteLine("HP: " + monster.HealthPoints);
        }
    }
}
