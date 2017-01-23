using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;

namespace PacifistUnitTest.CardTests.ActionCardTests
{
    [TestClass]
    public class WhenAssigningDuration
    {
        [TestMethod]
        public void ShouldCreateCardWithDuration()
        {
            const int expectedResult = 2;
            var card = new BreakCard(2, ToolEnum.Drill);
            Assert.AreEqual(expectedResult, card.RemainingDuration);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionCreatingCardWithZeroDuration()
        {
            var breakCard = new BreakCard(0, ToolEnum.Drill);
            Assert.IsNull(breakCard);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldThrowExceptionCreatingCardWithNegativeDuration()
        {
            var breakCard = new BreakCard(-10, ToolEnum.Drill);
            Assert.IsNull(breakCard);
        }
    }
}
