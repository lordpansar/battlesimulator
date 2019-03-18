using BattleSimulator.Services;
using System;
using Xunit;

namespace BattleSimulator.Tests
{
    public class BattleTests
    {
        BattleService service;

        public BattleTests()
        {
            service = new BattleService();
        }

        [Fact]
        public void AssertThatAttackerCanHurtDefender()
        {
            var isHit = service.Attack(5, 4);

            Assert.True(isHit);
        }

        [Theory]
        [InlineData(4, 5)]
        [InlineData(3, 3)]
        public void AssertThatDefenderCanDeflectAttack(int attackStrength, int defenseStrength)
        {
            var isHit = service.Attack(attackStrength, defenseStrength);

            Assert.False(isHit);
        }
    }
}
