﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Magician : IProffesion
    {
        private int hp;
        public Magician()
        {
            Strength = 10;
            Cleverness = 10;
            Intelligence = 20;
            Luck = 10;
            HealthPoints = 25000;
        }

        public int Luck { get; set; }
        public int Intelligence { get; set; }
        public int Cleverness { get; set; }
        public int Strength { get; set; }
        public int HealthPoints { get; set; }

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
            if (Cleverness < 2 || Strength < 2)
            {
                return false;
            }
            else
                return true;
        }
        public void Attack(IMonster monster, IWeapon weapon, int n)
        {
            monster.HealthPoints -= Damage(weapon,n);
        }
        public void SpecialAttack(IGameCharacter gameCharacter)
        {
            gameCharacter.HealthPoints += Intelligence*100;
            Strength -= 2;
            Cleverness -= 2;
        }

        public int Damage(IWeapon weapon,int n)
        {

            if (CriticalAttack(n))
                return 2*(weapon.AverageDamage()*50+ Intelligence * weapon.UpperRangeOfDamage);
            else
                return weapon.AverageDamage()*50 + Intelligence * weapon.UpperRangeOfDamage;
        }
    }
}