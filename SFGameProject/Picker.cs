using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class Picker
    {
        public string PickProfession()
        {
            Console.WriteLine("Pick your Profession:\n1 - Warrior\n2 - Hunter\n3 - Magician");
            string line = Console.ReadLine();
            while (line != "1" && line != "2" && line != "3")
            {
                line = Console.ReadLine();
            }
            return line;
        }
        public IProffesion Profession(string s,Warrior warrior, Hunter hunter, Magician magician)
        {
            if (s == "1")
            {
                return warrior;
            }
            else if (s == "2")
            {
                return hunter;
            }
            else
                return magician;
        }


        public string PickWeapon(Sword sword, Bow bow, Wand wand)
        {
            Console.WriteLine("Pick your Weapon:\n1 - Sword  Range of Damage: " + sword.LowerRangeOfDamage + "-" + sword.UpperRangeOfDamage);
            Console.WriteLine("2 - Bow  Range of Damage: " + bow.LowerRangeOfDamage + "-" + bow.UpperRangeOfDamage);
            Console.WriteLine("3 - Wand  Range of Damage: " + wand.LowerRangeOfDamage + "-" + wand.UpperRangeOfDamage);
            string line = Console.ReadLine();
            while (line != "1" && line != "2" && line != "3")
            {
                line = Console.ReadLine();
            }
            return line;
        }
        public IWeapon Weapon(string s, Sword sword, Bow bow, Wand wand)
        {
            if (s == "1")
            {
                return sword;
            }
            else if (s == "2")
            {
                return bow;
            }
            else
                return wand;
        }
    }
}
