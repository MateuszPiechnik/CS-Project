using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Goblin : IMonster
    {
        private int str;
        public Goblin(int level)
        {
            Level = level;
            Strength = 10;
            HealthPoints = level*5000;
        }
        public int Level { get; set; }
        public int Strength { 
            get { return str; } 
            set
            {
                str = Level * 10;
            }
        }
        public int HealthPoints { get; set; }

        public void DoDamage(IProffesion prof)
        {
            prof.HealthPoints -= Strength*50;
        }

        public void SpecialAbility(int turn)
        {
            ;
        }
    }
}
