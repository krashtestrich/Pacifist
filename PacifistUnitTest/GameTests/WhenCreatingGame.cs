using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Duration;
using Pacifist.Logic.Decks.Tool;
using Pacifist.Logic.Rules;
using Pacifist.Logic.Settings;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenCreatingGame : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldCreateGameWithStandardDependencies()
        {
            var game = new Game(
                new StandardDeckFactory(
                    new StandardDeckToolBuilder(
                        new StandardActionToolDuration())), 
                new StandardRuleSetFactory(),
                new DefaultGameSettingsFactory());
            Assert.IsNotNull(game);
        }

        [TestMethod]
        public void ShouldBuildDeck()
        {
            var game = GetGame();
            Assert.IsNotNull(game.Deck);
        }

        [TestMethod]
        public void ShouldBuildRuleSet()
        {
            var game = GetGame();
            Assert.IsNotNull(game.Rules);
        }

        [TestMethod]
        public void ShouldBuildSettings()
        {
            var game = GetGame();
            Assert.IsNotNull(game.Settings);
        }
    }
}
