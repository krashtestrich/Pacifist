using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenRemovingPlayersFromTheGame : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldRemovePlayerFromTheGame()
        {
            const int expectedResult = 0;
            var game = GetGame();
            
            var player = new Player();
            game.AddPlayer(player);
            Assert.IsTrue(game.Players.Any());
            game.RemovePlayer(player);
            Assert.AreEqual(expectedResult, game.Players.Count());
            
        }
    }
}
