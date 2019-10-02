using BattleSimulator.Models;
using System;

namespace BattleSimulator.Services
{
    public class WarriorService
    {
        public Warrior SpawnWarrior(int id)
        {
            return new Warrior
            {
                Id = id,
                Iniative = HelperService.Randomize(1,10),
                MinAttack = HelperService.Randomize(1, 3),
                MaxAttack = HelperService.Randomize(4, 8),
                MinDefense = HelperService.Randomize(2, 4),
                MaxDefense = HelperService.Randomize(5, 8),
                IsAlive = true
            };
        }
    }
}
