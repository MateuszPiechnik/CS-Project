using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    interface IMonster : IGameCharacter
    {
        int Level { get; set; }

        void DoDamage(IProffesion prof);
        void SpecialAbility(int turn);


    }
}
