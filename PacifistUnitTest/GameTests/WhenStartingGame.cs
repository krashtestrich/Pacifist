using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic;
using Pacifist.Logic.Players;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenStartingGame : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldSetTurn()
        {
            const int expectedResult = 1;
            var game = GetGame();
            Assert.IsNull(game.Turn);
            game.Start();
            Assert.AreEqual(expectedResult, game.Turn);
        }

        [TestMethod]
        public void ShouldStartGameWithoutBots()
        {
            var game = GetGame();
            game.ToggleBots(false);
            game.AddPlayer(new Player());
            game.AddPlayer(new Player());
            game.Start();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldNotStartGameWithoutMinPlayers()
        {
            var game = GetGame();
            game.ToggleBots(false);
            game.AddPlayer(new Player());
            game.Start();
        }

        [TestMethod]
        public void ShouldStartGameAndPopulateBots()
        {
            const int expectedResult = 5;
            var game = GetGame();
            Assert.AreEqual(0, game.Players.Count());
            game.Start();
            Assert.AreEqual(expectedResult, game.Players.Count());
        }

        [TestMethod]
        public void ShouldStartGameAndSetGameStatus()
        {
            const GameStatus expectedResult = GameStatus.Started;
            var game = GetGame();
            game.Start();
            Assert.AreEqual(expectedResult, game.Status);
        }
    }
}
