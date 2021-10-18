using System;
using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould : IDisposable
    {
        private readonly ITestOutputHelper outputHelper;
        private readonly PlayerCharacter _ps;
        public PlayerCharacterShould(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
            _ps = new PlayerCharacter();
            outputHelper.WriteLine("Hello test has been started");
        }

        public void Dispose() { 
        
        }
        // [Fact] --> this is the keyword that tell complier this method needs to be tested 
        [Fact]
        [Trait("category","check")]
        public void BeInExperienceWhenNew()
        {
            // bool property check
           
            Assert.True(_ps.IsNoob);
        }

        [Fact] 
        public void CalculateFullName()
        {
            // string property check
            _ps.FirstName = "Kinjal";
            _ps.LastName = "Shah";
            Assert.Equal("Kinjal Shah", _ps.FullName, ignoreCase : true);
            // we can do this many certain ways such as startwith, contains, substring Regular expression etc
        }

        // exmple to pass data commonly
        [Theory]
        [InlineData(1,101)]
        [InlineData(2, 102)]
        [InlineData(3, 103)]
        [InlineData(4, 104)]
        public void TakeDamage(int damage, int expectedhealth) {
            _ps.CalcualteDamage(damage);

            Assert.Equal(expectedhealth, _ps.Health);
        }


        //this common data used for two differnet methods
        [Theory]
        [MemberData(nameof(InternalHealthDamageTestData.TestData), MemberType = typeof(InternalHealthDamageTestData))]
        public void TakeDamageWithInternalMemberData(int damage, int expectedhealth)
        {
            _ps.CalcualteDamage(damage);

            Assert.Equal(expectedhealth, _ps.Health);
        }

        [Theory]
        [MemberData(nameof(ExternalHealthDamageTestData.TestData), MemberType = typeof(ExternalHealthDamageTestData))]
        public void TakeDamageWithExternalMemberData(int damage, int expectedhealth)
        {
            _ps.CalcualteDamage(damage);

            Assert.Equal(expectedhealth, _ps.Health);
        }

        [Theory]
        [HealthDamageDataAttribute]
        public void TakeDamageWithDataAttribute(int damage, int expectedhealth)
        {
            _ps.CalcualteDamage(damage);

            Assert.Equal(expectedhealth, _ps.Health);
        }
    }
}
