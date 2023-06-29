using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class AttackState : State
    {
        public AttackState(GameApp app) : base(app)
        {
        }

        public override void Action(string s)
        {
            while (s != "1" && s != "2" && s!= "koniec")
            {
                s = Console.ReadLine();
            }

            if (s == "1")
            {
                parentApp.ChangeState(new StatisticState(parentApp));
            }
            else if (s == "2")
            {
                System.Environment.Exit(1);
            }
            else if (s == "koniec")
            {
                parentApp.ChangeState(new EndGameState(parentApp));
            }
        }

        public override void Choice(string s, IProffesion proffesion, IWeapon weapon, IMonster monster, int n)
        {
            if (s == "1")
            {
                proffesion.Attack(monster, weapon, n);
            }
            else
            {
                if (proffesion.CheckSecondaryStats())
                {
                    if (proffesion is Hunter)
                    {
                        proffesion.SpecialAttack(monster);
                    }
                    else
                    {
                        proffesion.SpecialAttack(proffesion);
                    }
                }
                else
                {
                    proffesion.Attack(monster, weapon, n);
                }
            }
        }

        public override string Info()
        {
            return "It's time to fight. You have to choose whether you want to use normal attack (1) or special (2).\nIn a normal attack, there is a chance to deal a critical hit, which depends on the character's luck." +
                "Every profession has different special attack. \n- Warrior add extra " +
                "strength pointts to yourself by strengthening his attack. \n- Hunter performs stronger attack, substracting 5000 HP from the opponent. \n- Magician heals yourself by adding extra 1000HP.\n" +
                "You must remember that the special attack takes 2 points from the two secondary stats, when you don't have them, the normal attack will be performed. ";
        }
    }
}
