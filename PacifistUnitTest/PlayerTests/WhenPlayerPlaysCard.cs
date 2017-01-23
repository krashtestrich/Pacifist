using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.PlayerTests
{
    [TestClass]
    public class WhenPlayerPlaysCard
    {
        [TestMethod]
        public void ShouldRemoveCardFromPlayerHand()
        {
            const int expectedResult = 0;
            var player = new Player();
            Assert.IsTrue(!player.Hand.Any());
            player.ReceiveCard(new BreakCard(3, ToolEnum.Drill));
            player.PlayCard(0);
            Assert.AreEqual(expectedResult, player.Hand.Count());
        }
    }
}
