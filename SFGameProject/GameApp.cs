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

        public bool checkHP(IGameCharacter gameCharacter)
        {
            if (gameCharacter.HealthPoints > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool checkSecondaryStats(IProffesion prof)
        {
            if (prof.Cleverness < 2 || prof.Intelligence < 2 || prof.Strength < 2)
            {
                return false;
            }
            else return true;
        }

        public void AddStats(int x, IProffesion profession, Statistics stat)
        {
            while (x != 0)
            {
                Console.WriteLine(Info());
                Console.WriteLine("\n\nActual Stats:");
                stat.PrintStats(profession);
                Console.WriteLine("Points to distribute: " + x);
                string pts = "";
                Console.Write("\nYour choice: ");
                pts = Console.ReadLine();
                if (pts == "1")
                {
                    profession.Strength += 1;
                }
                else if (pts == "2")
                {
                    profession.Cleverness += 1;
                }
                else if (pts == "3")
                {
                    profession.Intelligence += 1;
                }
                else if (pts == "4")
                {
                    profession.Luck += 1;
                }
                else
                    profession.HealthPoints += 2000;
                x--;
            }
        }

        public void Duel(IProffesion proffesion, IMonster monster, IWeapon weapon, Statistics stats, int level)
        {
            Console.Clear();
            int turn = 1;
            int damage = 0;
            while (checkHP(proffesion) == true && checkHP(monster) == true)
            {
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
                string x = Console.ReadLine();
                if (x == "1")
                {
                    proffesion.Attack(monster, weapon,n);
                    damage = proffesion.Damage(weapon, n);
                }
                else
                {
                    if (checkSecondaryStats(proffesion))
                    {
                        if (proffesion is Hunter)
                        {
                            proffesion.SpecialAttack(monster);
                            damage = 3000;
                        }
                        else
                        {
                            proffesion.SpecialAttack(proffesion);
                        }
                    }
                    else
                    {
                        proffesion.Attack(monster, weapon, n);
                        damage = proffesion.Damage(weapon, n);
                    }

                }

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
