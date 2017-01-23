using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;

namespace PacifistUnitTest.CardTests.ActionCardTests
{
    [TestClass]
    public class WhenDecreasingDuration
    {
        [TestMethod]
        public void ShouldDecreaseDuration()
        {
            const int expectedResult = 1;
            var card = new BreakCard(2, ToolEnum.Drill);
            card.DecreaseDuration();
            Assert.AreEqual(expectedResult, card.RemainingDuration);
        }
    }
}
