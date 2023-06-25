using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    interface IWeapon
    {
        int LowerRangeOfDamage { get; set; }
        int UpperRangeOfDamage { get; set; }

        int AverageDamage();
        void ExtraAbility(IProffesion ch);
    }
}
