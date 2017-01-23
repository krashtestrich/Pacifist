using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.PlayerTests
{
    [TestClass]
    public class WhenPlayerReceivesActionCard
    {
        [TestMethod]
        public void ShouldAddActionCardToActiveCards()
        {
            const int expectedResult = 1;
            var player = new Player();
            Assert.IsTrue(!player.ActiveCards.Any());
            player.ReceiveActionCard(new BreakCard(3, ToolEnum.Drill));
            Assert.AreEqual(expectedResult, player.ActiveCards.Count());
        }
    }
}
