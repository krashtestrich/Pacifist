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

        [TestMethod]
        public void ShouldReturnExpectedMaxPlayers()
        {
            const int expectedResult = 8;
            var ruleSetFactory = new StandardRuleSetFactory();
            var rules = ruleSetFactory.Get();
            Assert.AreEqual(expectedResult, rules.MaxPlayers);
        }

        [TestMethod]
        public void ShouldReturnExpectedMinPlayers()
        {
            const int expectedResult = 2;
            var ruleSetFactory = new StandardRuleSetFactory();
            var rules = ruleSetFactory.Get();
            Assert.AreEqual(expectedResult, rules.MinPlayers);
        }
    }
}
