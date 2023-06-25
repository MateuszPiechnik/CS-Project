using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    abstract class State
    {
        protected GameApp parentApp;
        public State(GameApp app)
        {
            parentApp = app;
        }
        public abstract string Info();
        public abstract void Action(string s);
    }
}
