using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenAddingPlayersToTheGame : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldAddPlayerToTheGame()
        {
            const int expectedResult = 1;
            var game = GetGame();

            Assert.IsTrue(!game.Players.Any());
            var player = new Player();
            game.AddPlayer(player);
            Assert.AreEqual(expectedResult, game.Players.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldNotAddPlayerToTheGameWhenFull()
        {
            var game = GetGame();

            Assert.IsTrue(!game.Players.Any());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
        }
    }
}
