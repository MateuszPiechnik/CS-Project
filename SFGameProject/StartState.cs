using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class StartState : State
    {
        public StartState(GameApp app) : base(app)
        {

        }

        public override void Action(string s)
        {
            while(s!="1" && s != "2")
            {
                Console.Clear();
                Console.WriteLine(Info());
                s = Console.ReadLine();
            }

            if (s == "1"){
                parentApp.ChangeState(new PickerState(parentApp));
            }
            else if (s == "2")
            {
                System.Environment.Exit(1);
            }
        }

        public override void Choice(string s, IProffesion proffesion, IWeapon weapon, IMonster monster, int n)
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {
            return "Welcome to the game!\nThe goal of the game is to beat 10 opponents and not to die\nEverything depends on your choice. So it is important tho choose " +
                "wisely, because as you level up, you have to defeat stronger opponents\n" +
                "\n1 - next\n2 - quit game";
        }
    }
}
