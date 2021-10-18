using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GameEngine.Tests
{
   public class ExternalHealthDamageTestData
    {
        public static IEnumerable<object[]> TestData
        {

            get
            {
                string[] csvlines = File.ReadAllLines("TestData.csv");

                var testCases = new List<object[]>();
                foreach (var item in csvlines)
                {
                    IEnumerable<int> values = item.Split(',').Select(int.Parse);

                    object[] testcase = values.Cast<object>().ToArray();
                    testCases.Add(testcase);
                }
                return testCases;
            }
        }
    }
}
