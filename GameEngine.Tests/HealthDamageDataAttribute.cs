using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit.Sdk;

namespace GameEngine.Tests
{
    public class HealthDamageDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 1, 101 };
            yield return new object[] { 2, 102 };
            yield return new object[] { 3, 103 };
            yield return new object[] { 4, 104 };
        }
    }
}
