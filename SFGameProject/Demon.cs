using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Demon : IMonster
    {
        public Demon(int level)
        {
            Level = level;
            Strength = level*20;
            HealthPoints = level * 20000;
        }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int HealthPoints { get; set; }

        public void SpecialAbility(int turn)
        {
            Strength += turn * 2;
        }

        public void DoDamage(IProffesion prof)
        {
            prof.HealthPoints -= Strength * 20;
        }
    }
}
