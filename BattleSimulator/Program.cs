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
            
            var warriors = warriorService.SpawnWarriors(4);
            var list2 = new List<Warrior>();
            list2.Add(warriors[2]);
            list2.Add(warriors[3]);

            battleService.CommenceBattle(warriors);
            battleService.CommenceBattle(list2);
        }
    }
}
