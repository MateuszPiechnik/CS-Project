using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Hunter : IProffesion
    {
        public Hunter()
        {
            Luck = 15;
            Intelligence = 10;
            Cleverness = 20;
            Strength = 10;
            HealthPoints = 35000;
        }
        public int Luck { get; set; }
        public int Intelligence { get; set; }
        public int Cleverness { get; set; }
        public int Strength { get; set; }
        public int HealthPoints { get; set; }

        public void Attack(IMonster monster, IWeapon weapon, int n)
        {
            monster.HealthPoints -= Damage(weapon,n);
        }

        public bool CriticalAttack(int n)
        {
            if (Luck > n)
            {
                return true;
            }
            else
                return false;
        }
        public bool CheckSecondaryStats()
        {
            if (Strength < 2 || Intelligence < 2)
            {
                return false;
            }
            else
                return true;
        }

        public int Damage(IWeapon weapon, int n)
        {
            if (CriticalAttack(n)) 
                return 2* (6*weapon.AverageDamage() + (2*Cleverness * weapon.LowerRangeOfDamage));
            else
                return 3*weapon.AverageDamage() + (2*Cleverness * weapon.LowerRangeOfDamage);
        }

        public void SpecialAttack(IGameCharacter gameCharacter)
        {
            gameCharacter.HealthPoints -= 3500;
            Strength -= 2;
            Intelligence -= 2;
        }
    }
}
