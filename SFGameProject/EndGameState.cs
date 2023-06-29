using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class EndGameState : State
    {
        public EndGameState(GameApp app) : base(app)
        {
        }

        public override void Action(string s)
        {
            throw new NotImplementedException();
        }

        public override void Choice(string s, IProffesion proffesion, IWeapon weapon, IMonster monster, int n)
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {
            Console.Clear();
            return "\r\nCongratulations, you've defeated all your opponents and completed the game!";
        }
    }
}
