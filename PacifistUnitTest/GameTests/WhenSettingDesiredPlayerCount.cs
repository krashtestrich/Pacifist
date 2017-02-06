using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PacifistUnitTest.GameTests
{
    [TestClass]
    public class WhenSettingDesiredPlayerCount : StandardGameTestBase
    {
        [TestMethod]
        public void ShouldSetCount()
        {
            const int expectedResult = 3;
            var game = GetGame();
            Assert.AreNotEqual(expectedResult, game.Settings.DesiredPlayerCount);
            game.SetDesiredPlayers(3);
            Assert.AreEqual(expectedResult, game.Settings.DesiredPlayerCount);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldNotSetCountBelowMin()
        {
            var game = GetGame();
            game.SetDesiredPlayers(1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ShouldNotSetCountAboveMax()
        {
            var game = GetGame();
            game.SetDesiredPlayers(9);
        }
    }
}
