using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GameEngine.Tests
{
   public class NonPlayerCharacterShould
    {
        [Theory]
        [MemberData(nameof(InternalHealthDamageTestData.TestData),MemberType = typeof(InternalHealthDamageTestData)) ]
        public void TakeDamageInternal(int damage, int expectedhealth)
        {
            PlayerCharacter _ps = new PlayerCharacter();
            _ps.CalcualteDamage(damage);

            Assert.Equal(expectedhealth, _ps.Health);
        }

        [Theory]
        [MemberData(nameof(ExternalHealthDamageTestData.TestData), MemberType = typeof(ExternalHealthDamageTestData))]
        public void TakeDamageExternal(int damage, int expectedhealth)
        {
            PlayerCharacter _ps = new PlayerCharacter();
            _ps.CalcualteDamage(damage);

            Assert.Equal(expectedhealth, _ps.Health);
        }
    }
}
