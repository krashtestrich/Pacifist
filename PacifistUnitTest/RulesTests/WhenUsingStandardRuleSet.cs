using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Rules;

namespace PacifistUnitTest.RulesTests
{
    [TestClass]
    public class WhenUsingStandardRuleSet
    {
        [TestMethod]
        public void ShouldReturnExpectedStartingCards()
        {
            const int expectedResult = 6;
            var ruleSetFactory = new StandardRuleSetFactory();
            var rules = ruleSetFactory.Get();
            Assert.AreEqual(expectedResult, rules.StartingCards);
        }
    }
}
