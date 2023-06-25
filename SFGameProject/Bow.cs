using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Bow : IWeapon
    {
        public Bow()
        {
            Random rand = new Random();
            int r = rand.Next(10, 25);
            LowerRangeOfDamage = r;
            r = rand.Next(26, 40);
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
            ch.Cleverness += 15;
        }
    }
}
