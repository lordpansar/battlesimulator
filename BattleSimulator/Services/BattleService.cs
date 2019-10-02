using BattleSimulator.Models;
using System.Collections.Generic;

namespace BattleSimulator.Services
{
    public class BattleService
    {
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
