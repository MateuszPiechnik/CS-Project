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
            Sword goblinSword2 = new Sword();
            Sword goblinSword3 = new Sword();
            Goblin goblin1 = new Goblin(1);
            Goblin goblin2 = new Goblin(2);
            Goblin goblin3 = new Goblin(4);
            Goblin goblin4 = new Goblin(5);
            Goblin goblin5 = new Goblin(7);
            Goblin goblin6 = new Goblin(8);

           
            GoblinChief goblinC1 = new GoblinChief(3, goblinSword);
            GoblinChief goblinC2 = new GoblinChief(6, goblinSword2);
            GoblinChief goblinC3 = new GoblinChief(9, goblinSword3);
            Demon demon = new Demon(10);

            List<IMonster> monsterList = new List<IMonster> { goblin1,goblin2,goblinC1,goblin3,goblin4,goblinC2,goblin5,goblin6,goblinC3,demon };

            int level=1;
            foreach (IMonster monster in monsterList)
            {
                app.Duel(prof, monster, wp, stat, level);
                if (level == 10)
                {
                    app.Action("koniec");
                    Console.WriteLine(app.Info());
                }
                else
                {
                    string str = "";
                    str = Console.ReadLine();
                    app.Action(str);
                    int x = level * 5;
                    while (x != 0)
                    {
                        app.AddStats(x, prof, stat);
                        string pts;
                        pts = Console.ReadLine();
                        app.Choice(pts, prof, wp, monster, x);
                        x--;
                    }                   
                    level++;
                    Console.WriteLine("1 - Go to level " + level + " 2 - quit game");
                    str = Console.ReadLine();
                    app.Action(str);
                }
            }
        }
    }
}
