using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenTogglingBots : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldDisableBots()
        {
            var game = GetGame();
            Assert.IsTrue(game.Settings.AllowBots);
            game.ToggleBots(false);
            Assert.IsFalse(game.Settings.AllowBots);
        }
    }
}
