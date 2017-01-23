using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.PlayerTests
{
    [TestClass]
    public class WhenPerformingRoundEndTasks
    {
        [TestMethod]
        public void ShouldRemoveExpiredActionCard()
        {
            const int expectedResult = 0;
            var player = new Player();
            player.ReceiveActionCard(new BreakCard(1, ToolEnum.Drill));
            Assert.IsTrue(player.ActiveCards.Count() == 1);
            player.PerformRoundEndTasks();
            Assert.AreEqual(expectedResult, player.ActiveCards.Count());
        }

        [TestMethod]
        public void ShouldOnlyRemoveExpiredActionCard()
        {
            const int expectedResult = 1;
            var player = new Player();
            player.ReceiveActionCard(new BreakCard(1, ToolEnum.Drill));
            player.ReceiveActionCard(new BreakCard(2, ToolEnum.Drill));
            Assert.IsTrue(player.ActiveCards.Count() == 2);
            player.PerformRoundEndTasks();
            Assert.AreEqual(expectedResult, player.ActiveCards.Count());
        }

        [TestMethod]
        public void ShouldNotRemoveNonExpiredActionCards()
        {
            const int expectedResult = 2;
            var player = new Player();
            player.ReceiveActionCard(new BreakCard(3, ToolEnum.Drill));
            player.ReceiveActionCard(new BreakCard(2, ToolEnum.Drill));
            Assert.IsTrue(player.ActiveCards.Count() == 2);
            player.PerformRoundEndTasks();
            Assert.AreEqual(expectedResult, player.ActiveCards.Count());
        }
    }
}
