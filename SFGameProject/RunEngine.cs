using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class RunEngine
    {
        public void Run()
        {
            GameApp app = new GameApp();
            Console.WriteLine(app.Info());
            string s = Console.ReadLine();
            app.Action(s);
            Console.WriteLine(app.Info());


            Sword sw = new Sword();
            Bow bow = new Bow();
            Wand wand = new Wand();

            Warrior warrior = new Warrior();
            Hunter hunter = new Hunter();
            Magician magician = new Magician();

            Picker pick = new Picker();
            Statistics stat = new Statistics();


            string weapon = pick.PickWeapon(sw, bow, wand);
            IWeapon wp = pick.Weapon(weapon, sw, bow, wand);

            string proffesion = pick.PickProfession();
            IProffesion prof = pick.Profession(proffesion, warrior, hunter, magician);

            wp.ExtraAbility(prof);
            app.Action(s);

            Sword goblinSword = new Sword();
            Goblin gob = new Goblin(1);
            Goblin gob2 = new Goblin(2);
            GoblinChief goblinC = new GoblinChief(3, goblinSword);
            Demon demon = new Demon(1);

            List<IMonster> monsterList = new List<IMonster> { gob, gob2,goblinC };

            int level=1;
            foreach(IMonster monster in monsterList)
            {
                app.Duel(prof, monster, wp, stat, level);
                string str = "";
                str = Console.ReadLine();
                app.Action(str);
                app.AddStats(level*5, prof,stat);
                level++;
                Console.WriteLine("1 - Go to level " + level + "2 - quit game");
                str = Console.ReadLine();
                app.Action(str);
            }
        }
    }
}
