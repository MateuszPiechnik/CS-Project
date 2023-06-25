using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class PickerState : State
    {
        public PickerState(GameApp app) : base(app)
        {
        }

        public override void Action(string s)
        {
            parentApp.ChangeState(new AttackState(parentApp));
        }

        public override string Info()
        {
            Console.Clear();
            return "Your first step is to pick your weapon and type of proffesion.\nEvery profession has it's main property (Warrior - strength, Hunter - Cleveerness and Magician - Intelligence)\n" +
                "Our damage depends on it. It's the same with weapons. The weapon's damage range is listed next to the weapon. \nAdditionally every weapon gives some stats to our profession.\n" +
                "Sword gives points to Strength, Bow to Cleverness and Wand to Luck\n";
        }
    }
}
