using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.PlayerTests
{
    [TestClass]
    public class WhenPlayerReceivesCard
    {
        [TestMethod]
        public void ShouldAddCardToPlayerHand()
        {
            const int expectedResult = 1;
            var player = new Player();
            Assert.IsTrue(!player.Hand.Any());
            player.ReceiveCard(new BreakCard(1, ToolEnum.Drill));
            Assert.AreEqual(expectedResult, player.Hand.Count());
        }
    }
}
