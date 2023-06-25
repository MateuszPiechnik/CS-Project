using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class GoblinChief : IMonster
    {
        private Sword sword;
        private int str;
        public GoblinChief(int level, Sword sword)
        {
            Level = level;
            this.sword = sword;
            Strength = 15;
            HealthPoints = 15000 * Level;
        }

        public int Level { get; set; }
        public int Strength 
        {
            get { return str; }
            set
            {
                str = Level * 15;
            }
        }
        public int HealthPoints { get; set; }

        public void DoDamage(IProffesion prof)
        {
            prof.HealthPoints -= sword.AverageDamage() + Strength * 100;
        }

        public void SpecialAbility(int turn)
        {
            ;
        }
    }
}
