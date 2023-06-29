using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Warrior : IProffesion
    {
        public Warrior()
        {
            Luck = 15;
            Intelligence = 10;
            Cleverness = 10;
            Strength = 20;
            HealthPoints = 40000;
        }
        public int Luck { get; set; }
        public int Intelligence { get; set; }
        public int Cleverness { get; set; }
        public int Strength { get; set; }
        public int HealthPoints { get; set; }

        public void Attack(IMonster monster, IWeapon weapon,int n)
        {
            monster.HealthPoints -=Damage(weapon,n);
        }

        public bool CheckSecondaryStats()
        {
            if (Cleverness < 2 || Intelligence < 2)
            {
                return false;
            }
            else
                return true;
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

        public int Damage(IWeapon weapon, int n)
        {
            if (CriticalAttack(n))
            {
                return 6* weapon.AverageDamage() * Strength;
            }
            else
                return 3*weapon.AverageDamage() * Strength;
        }
        public void SpecialAttack(IGameCharacter gameCharacter)
        {
            gameCharacter.Strength += 5;
            Cleverness -= 2;
            Intelligence -= 2;
        }
    }
}
