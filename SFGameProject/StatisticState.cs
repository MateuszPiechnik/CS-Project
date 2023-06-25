using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class StatisticState : State
    {
        public StatisticState(GameApp app) : base(app)
        {
        }

        public override void Action(string s)
        {
            while (s != "1" && s != "2")
            {
                s = Console.ReadLine();
            }

            if (s == "1")
            {
                parentApp.ChangeState(new AttackState(parentApp));
            }
            else if (s == "2")
            {
                System.Environment.Exit(1);
            }
        }

        public override string Info()
        {
            Console.Clear();
            return "After each defeated level, we need to add stats for our character. The amount of points we can allocate is level*5." +
                "\nChoose: \n- 1 - add 1 point to Strength, \n- 2 - add 1 point to Cleverness, \n- 3 - add 1 point to Intelligence, \n- 4 - add 1 point to Luck, " +
                "\n- 5 - add 2000 Health Points";
        }
    }
}
