using BattleSimulator.Models;
using BattleSimulator.Services;
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
        public void AssertThatWarriorCanBeCreated()
        {
            var warrior = service.SpawnWarrior(1);
            var expected = typeof(Warrior);

            Assert.IsType(expected, warrior);    
        }
    }
}
