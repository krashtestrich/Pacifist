using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Duration;
using Pacifist.Logic.Decks.Tool;
using Pacifist.Logic.Players;
using Pacifist.Logic.Rules;

namespace PacifistUnitTest.GameTests.PlayerEventsTests
{
    [TestClass]
    public class WhenPlayerActionCardExpires
    {
        [TestMethod]
        public void ShouldAddCardToDiscardPile()
        {
            const int expectedResult = 1;
            var game = new Game(
                new StandardDeckFactory(
                    new StandardDeckToolBuilder(
                        new StandardActionToolDuration())),
                new StandardRuleSetFactory());
            var player = new Player();
            game.AddPlayer(player);
            player.ReceiveActionCard(new BreakCard(1, ToolEnum.Drill));
            Assert.IsTrue(!game.DiscardPile.Any());
            player.PerformRoundEndTasks();
            Assert.AreEqual(expectedResult, game.DiscardPile.Count());
        }
    }
}
