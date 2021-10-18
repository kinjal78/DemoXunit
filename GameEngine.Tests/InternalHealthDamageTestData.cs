using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.Tests
{
    //this class is created to share data accross multiple methods
   public class InternalHealthDamageTestData
    {
        public static IEnumerable<object[]> TestData {

            get
            {
                yield return new object[] { 1,101};
                yield return new object[] { 2, 102 };
                yield return new object[] { 3, 103 };
                yield return new object[] { 4, 104 };
            }
        }
    }
}
