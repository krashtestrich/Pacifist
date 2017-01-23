using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.GameTests.PlayerEventsTests
{
    [TestClass]
    public class WhenPlayerActionCardExpires : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldAddCardToDiscardPile()
        {
            const int expectedResult = 1;
            var game = GetGame();
            var player = new Player();
            game.AddPlayer(player);
            player.ReceiveActionCard(new BreakCard(1, ToolEnum.Drill));
            Assert.IsTrue(!game.DiscardPile.Any());
            player.PerformRoundEndTasks();
            Assert.AreEqual(expectedResult, game.DiscardPile.Count());
        }
    }
}
