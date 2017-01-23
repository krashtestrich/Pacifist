using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Cards.Action;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.GameTests.PlayerEventsTests
{
    [TestClass]
    public class WhenPlayerPlaysCard : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldAddCardToGameBoard()
        {
            const int expectedResult = 1;
            var game = GetGame();
            var player = new Player();
            game.AddPlayer(player);
            player.ReceiveCard(new BreakCard(2, ToolEnum.Drill));
            Assert.IsTrue(!game.GameBoard.CardsInPlay.Any());
            player.PlayCard(0);
            Assert.AreEqual(expectedResult, game.GameBoard.CardsInPlay.Count);
        }
    }
}
