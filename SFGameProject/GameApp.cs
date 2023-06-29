using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFGameProject
{
    internal class GameApp
    {
        private State currentState;
        
        public GameApp()
        {
            currentState = new StartState(this);
        }
        public void ChangeState(State newState)
        {
            currentState = newState;
        }

        public string Info()
        {
            return currentState.Info();
        }

        public void Action(string s)
        {
            currentState.Action(s);
        }

        public void Choice(string s, IProffesion proffesion, IWeapon weapon, IMonster monster, int n)
        {
            currentState.Choice( s,  proffesion,  weapon,  monster,  n);
        }

        public bool checkHP(IGameCharacter gameCharacter)
        {
            if (gameCharacter.HealthPoints > 0)
            {
                return true;
            }
            else
                return false;
        }


        public void AddStats(int x, IProffesion profession, Statistics stat)
        {
            Console.WriteLine(Info());
            Console.WriteLine("\n\nActual Stats:");
            stat.PrintStats(profession);
            Console.WriteLine("Points to distribute: " + x);

            Console.Write("\nYour choice: ");
        }

        public void Duel(IProffesion proffesion, IMonster monster, IWeapon weapon, Statistics stats, int level)
        {
            Console.Clear();
            int turn = 1;
            int damage = 0;
            int monsterHealth;
            while (checkHP(proffesion) == true && checkHP(monster) == true)
            {
                monsterHealth = monster.HealthPoints;
                Console.WriteLine(Info());
                Random random = new Random();
                int n = random.Next(0, 50);

                if(turn !=1)
                {
                    Console.WriteLine("\nYour damage in last turn:" + damage);
                }

                Console.WriteLine("\nLEVEL " + level);

                Console.WriteLine("\nMonster Stats:");
                stats.MonsterStats(monster);

                Console.Write("\n---------------------------\nYour stats:\n");
                stats.PrintStats(proffesion);


                Console.Write("\n\nTurn: " + turn + "\nChoice: ");
                string s = Console.ReadLine();
                Choice(s, proffesion, weapon, monster, n);

                damage = monsterHealth - monster.HealthPoints;

                if (checkHP(monster) == false)
                {
                    break;
                }
                else
                {
                    if (monster is Demon)
                    {
                        monster.DoDamage(proffesion);
                        monster.SpecialAbility(turn);
                    }
                    else
                        monster.DoDamage(proffesion);
                }
                Console.Clear();
                turn++;
            }
            if (proffesion.HealthPoints > 0)
            {
                Console.WriteLine("Congratulations! You passed level " + level);
                Console.WriteLine("\n1 - continue 2 - exit game\n");
            }
            else
            {
                Console.WriteLine("\r\nUnfortunately, the opponent turned out to be too strong and you failed to complete the game and you end your journey on level " + level + " :(");
                System.Environment.Exit(1);
            }
        }
    }
}
