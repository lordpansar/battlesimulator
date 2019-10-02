using BattleSimulator.Models;
using BattleSimulator.Services;
using System;
using System.Collections.Generic;

namespace BattleSimulator
{
    class Program
    {

        static void Main(string[] args)
        {
            RunTestFight();
            Console.ReadLine();
        }

        static void RunTestFight()
        {
            WarriorService warriorService = new WarriorService();
            BattleService battleService = new BattleService();
            var warriors = new List<Warrior>();

            var crogar = warriorService.SpawnWarrior(1);
            var torulf = warriorService.SpawnWarrior(2);

            warriors.Add(crogar);
            warriors.Add(torulf);

            battleService.CommenceBattle(warriors);
        }
    }
}
