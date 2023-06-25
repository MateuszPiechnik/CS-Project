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

        public override string Info()
        {
            return "\r\nCongratulations, you've defeated all your opponents and completed the game!";
        }
    }
}
