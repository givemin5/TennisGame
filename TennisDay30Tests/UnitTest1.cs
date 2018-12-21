using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisDay30;

namespace TennisDay30Tests
{
    [TestClass]
    public class TennisTests
    {
        [TestMethod]
        public void Love_All()
        {
            var tennis = new Tennis();
            Assert.AreEqual("Love All", tennis.Score());
        }
    }
}