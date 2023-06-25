using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Wand : IWeapon
    {
        public Wand()
        {
            Random rand = new Random();
            int r = rand.Next(10, 30);
            LowerRangeOfDamage = r;
            r = rand.Next(31, 50);
            UpperRangeOfDamage = r;
        }
        public int LowerRangeOfDamage { get; set; }
        public int UpperRangeOfDamage { get; set; }

        public int AverageDamage()
        {
            return (LowerRangeOfDamage + UpperRangeOfDamage) / 2;
        }

        public void ExtraAbility(IProffesion ch)
        {
            ch.Luck += 20;
        }
    }
}
