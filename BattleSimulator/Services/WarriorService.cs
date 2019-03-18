using BattleSimulator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleSimulator.Services
{
    public class WarriorService
    {
        public object SpawnNewWarrior(int id)
        {
            return new Warrior
            {
                Id = id,
                MinAttack = Randomize(1, 3),
                MaxAttack = Randomize(4, 8),
                MinDefense = Randomize(2, 4),
                MaxDefense = Randomize(5, 8),
                IsAlive = true
            };
        }

        public int Randomize(int min, int max)
        {
            var random = new Random();

            return random.Next(min, max);
        }
    }
}
