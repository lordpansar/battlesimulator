using BattleSimulator.Models;
using System;
using System.Collections.Generic;

namespace BattleSimulator.Services
{
    public class WarriorService
    {
        public Warrior SpawnWarrior(int id)
        {
            return new Warrior
            {
                Id = id,
                Name = GenerateName(),
                Iniative = HelperService.Randomize(1,10),
                MinAttack = HelperService.Randomize(1, 3),
                MaxAttack = HelperService.Randomize(4, 8),
                MinDefense = HelperService.Randomize(2, 4),
                MaxDefense = HelperService.Randomize(5, 8),
                IsAlive = true
            };
        }

        public List<Warrior> SpawnWarriors(int number)
        {
            var warriors = new List<Warrior>();
            Warrior warrior;

            for (int warriorCount = 1; warriorCount < number+1; warriorCount++)
            {
                warrior = SpawnWarrior(warriorCount);
                warriors.Add(warrior);
            }

            return warriors;
        }

        public string GenerateName()
        {
            var first = HelperService.Randomize(1, 10);
            var second = HelperService.Randomize(1, 10);

            var firstName = "";
            string lastName = "";

            switch (first)
            {
                case 1:
                    firstName = "Crogar";
                    break;
                case 2:
                    firstName = "Torulf";
                    break;
                case 3:
                    firstName = "Grognak";
                    break;
                case 4:
                    firstName = "Conan";
                    break;
                case 5:
                    firstName = "Hagrid";
                    break;
                case 6:
                    firstName = "Stoneface";
                    break;
                case 7:
                    firstName = "Edgar";
                    break;
                case 8:
                    firstName = "Thy Dungeonman";
                    break;
                case 9:
                    firstName = "Grokk";
                    break;
                case 10:
                    firstName = "Bork";
                    break;
                default:
                    firstName = "Mr Alias";
                    break;
            }

            switch (second)
            {
                case 1:
                    lastName = "the Horrible";
                    break;
                case 2:
                    lastName = "Swordsbane";
                    break;
                case 3:
                    lastName = "the Fat";
                    break;
                case 4:
                    lastName = "Gutmuncher";
                    break;
                case 5:
                    lastName = "the Awful";
                    break;
                case 6:
                    lastName = "Armbreaker";
                    break;
                case 7:
                    lastName = "the Terrible";
                    break;
                case 8:
                    lastName = "von Hell";
                    break;
                case 9:
                    lastName = "the Smelly";
                    break;
                case 10:
                    lastName = "Thunderaxe";
                    break;
                default:
                    lastName = "Undercover";
                    break;
            }

            return $"{firstName} {lastName}";
        }
    }
}
