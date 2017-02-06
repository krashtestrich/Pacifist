using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacifist.Logic.Settings;

namespace PacifistUnitTest.GameSettings
{
    [TestClass]
    public class WhenUsingDefaultGameSettings
    {
        [TestMethod]
        public void ShouldReturnExpectedAllowBots()
        {
            var defaultGameSettings = 
                new DefaultGameSettingsFactory()
                .Get();
            Assert.IsTrue(defaultGameSettings.AllowBots);
        }

        [TestMethod]
        public void ShouldReturnExpectedDesiredPlayerCount()
        {
            const int expectedResult = 5;
            var defaultGameSettings = 
                new DefaultGameSettingsFactory()
                .Get();
            Assert.AreEqual(expectedResult, defaultGameSettings.DesiredPlayerCount);
        }
    }
}
