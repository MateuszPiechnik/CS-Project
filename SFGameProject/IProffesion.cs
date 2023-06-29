using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    interface IProffesion : IGameCharacter
    {
        int Luck { get; set; }
        int Intelligence { get; set; }
        int Cleverness { get; set; }

        int Damage(IWeapon weapon, int n);
        void Attack(IMonster monster, IWeapon weapon, int n);
        void SpecialAttack(IGameCharacter gameCharacter);
        bool CriticalAttack(int n);

        bool CheckSecondaryStats();


    }
}
