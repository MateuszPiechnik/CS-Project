using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Sword : IWeapon
    {
        public int LowerRangeOfDamage { get; set; }
        public int UpperRangeOfDamage { get; set; }

        public Sword()
        {
            Random random = new Random();
            int rand = random.Next(10, 20);
            LowerRangeOfDamage = rand;
            rand = random.Next(21, 30);
            UpperRangeOfDamage = rand;
        }
        public int AverageDamage()
        {
            return (LowerRangeOfDamage + UpperRangeOfDamage) / 2;
        }

        public void ExtraAbility(IProffesion ch)
        {
            ch.Strength += 10;
        }
    }
}
