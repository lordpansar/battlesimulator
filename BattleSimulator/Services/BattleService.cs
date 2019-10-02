using BattleSimulator.Models;
using System.Collections.Generic;

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
            else if(second.Iniative > first.Iniative)
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
                var defenderIsHurt = Attack(HelperService.Randomize(first.MinAttack, first.MaxAttack), HelperService.Randomize(second.MinDefense, second.MaxDefense));

                if (defenderIsHurt)
                {
                    second.IsAlive = false;
                    break;
                }
                else
                {
                    defenderIsHurt = Attack(HelperService.Randomize(second.MinAttack, second.MaxAttack), HelperService.Randomize(first.MinDefense, first.MaxDefense));

                    if (defenderIsHurt)
                    {
                        first.IsAlive = false;
                        break;
                    }
                }
            }
        }

        public bool Attack(int attack, int defense)
        {
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
    }
}
