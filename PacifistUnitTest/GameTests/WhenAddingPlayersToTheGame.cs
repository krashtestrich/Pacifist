using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Duration;
using Pacifist.Logic.Decks.Tool;
using Pacifist.Logic.Players;
using Pacifist.Logic.Rules;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenAddingPlayersToTheGame
    {
        [TestMethod]
        public void ShouldAddPlayerToTheGame()
        {
            const int expectedResult = 1;
            var game = new Game(
                new StandardDeckFactory(
                    new StandardDeckToolBuilder(
                        new StandardActionToolDuration())), 
                new StandardRuleSetFactory() );

            Assert.IsTrue(!game.Players.Any());
            var player = new Player();
            game.AddPlayer(player);
            Assert.AreEqual(expectedResult, game.Players.Count());
        }
    }
}
