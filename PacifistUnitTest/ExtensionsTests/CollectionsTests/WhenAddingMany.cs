using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PacifistInfrastructure.Extensions;

namespace PacifistUnitTest.ExtensionsTests.CollectionsTests
{
    [TestClass]
    public class WhenAddingMany
    {
        [TestMethod]
        public void ShouldAddMany()
        {
            const int expectedResult = 2;
            var test = new List<IOException>();
            test.AddMany(typeof(IOException), 2);
            Assert.AreEqual(expectedResult, test.Count);
        }
    }
}
