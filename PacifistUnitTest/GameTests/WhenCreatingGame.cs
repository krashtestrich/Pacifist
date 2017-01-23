using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic;
using Pacifist.Logic.Decks;
using Pacifist.Logic.Decks.Duration;
using Pacifist.Logic.Decks.Tool;
using Pacifist.Logic.Rules;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenCreatingGame 
    {
        [TestMethod]
        public void ShouldCreateGameWithStandardDeckAndStandardRules()
        {
            var game = new Game(
                new StandardDeckFactory(
                    new StandardDeckToolBuilder(
                        new StandardActionToolDuration())), 
                new StandardRuleSetFactory());
            Assert.IsNotNull(game);
        }
    }
}
