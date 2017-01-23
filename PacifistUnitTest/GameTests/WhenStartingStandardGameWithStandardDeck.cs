using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenStartingStandardGameWithStandardDeck : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldBuildDeck()
        {
            var game = GetGame();
            Assert.IsNull(game.Deck);
            game.Start();
            Assert.IsNotNull(game.Deck);
        }

        [TestMethod]
        public void ShouldSetTurn()
        {
            const int expectedResult = 1;
            var game = GetGame();
            Assert.IsNull(game.Turn);
            game.Start();
            Assert.AreEqual(expectedResult, game.Turn);
        }
    }
}
