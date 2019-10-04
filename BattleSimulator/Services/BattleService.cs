using BattleSimulator.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BattleSimulator.Services
{
    public class BattleService
    {
        public void CommenceBattle(List<Warrior> warriors)
        {
            var first = new Warrior();
            var second = new Warrior();

            if (warriors[0].Iniative > warriors[1].Iniative)
            {
                //If first draws first
                first = warriors[0];
                second = warriors[1];
            }
            else if(warriors[1].Iniative > warriors[0].Iniative)
            {
                //If second draws first
                first = warriors[1];
                second = warriors[0];
            }
            else
            {
                //Randomize draw success
                var roll = HelperService.Randomize(1, 2);

                if (roll == 1)
                {
                    first = warriors[0];
                    second = warriors[1];
                }
                else
                {
                    first = warriors[1];
                    second = warriors[0];
                }
            }

            while (first.IsAlive && second.IsAlive)
            {
                //Battle to death
                Console.WriteLine($"{first.Name} furiously attacks!");
                var defenderIsHurt = Attack(HelperService.Randomize(first.MinAttack, first.MaxAttack), HelperService.Randomize(second.MinDefense, second.MaxDefense));

                if (defenderIsHurt)
                {
                    second.IsAlive = false;
                    Console.WriteLine($"{first.Name} viciously slays {second.Name}. May he feast forever in Valhalla.\n");
                    break;
                }
                else
                {
                    Deflect(first.Name, second.Name);
                    Console.WriteLine($"{second.Name} furiously attacks!");
                    
                    defenderIsHurt = Attack(HelperService.Randomize(second.MinAttack, second.MaxAttack), HelperService.Randomize(first.MinDefense, first.MaxDefense));

                    if (defenderIsHurt)
                    {
                        first.IsAlive = false;
                        Console.WriteLine($"{second.Name} viciously slays {first.Name}. May he feast forever in Valhalla.\n");
                        break;
                    }

                    Deflect(second.Name, first.Name);
                }
            }
        }

        public bool Attack(int attack, int defense)
        {
            Console.WriteLine($"Attack: {attack} Defense: {defense}");

            //Attack must be greater than defense to inflict damage
            if(attack > defense)
            {
                return true;
            }
            //Defense must be greater than or equal to attack power to deflect attack
            else
            {
                return false;
            }
        }

        private void Deflect(string attackerName, string defenderName)
        {
            Console.WriteLine($"Haha! {attackerName}'s puny sword is no match for {defenderName}'s mighty armour!\n");
        }
    }
}
