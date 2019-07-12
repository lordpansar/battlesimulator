using BattleSimulator.Models;
using BattleSimulator.Services;
using System;
using Xunit;

namespace BattleSimulator.Tests
{
    public class WarriorTests
    {
        WarriorService service;

        public WarriorTests()
        {
            service = new WarriorService();
        }

        [Fact]
        public void AssertThatRandomizedValuesAreInRange()
        {
            bool isInRange = false;

            var returnValue = service.Randomize(1, 5);

            if(returnValue >= 1 && returnValue <= 5)
            {
                isInRange = true;
            }

            Assert.True(isInRange);
        }

        [Fact]
        public void AssertThatWarriorCanBeCreated()
        {
            var warrior = service.SpawnNewWarrior(1);
            var expected = typeof(Warrior);

            Assert.IsType(expected, warrior);    
        }
    }
}
