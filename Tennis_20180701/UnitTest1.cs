using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tennis_20180701
{
    [TestClass]
    public class TennisTests
    {
        [TestMethod]
        public void love_all()
        {
            var tennis = new Tennis();
            var score = tennis.Score();
            Assert.AreEqual("Love All", score);
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            var tennis = new Tennis();
            tennis.FirstPlayerScore();
            var score = tennis.Score();
            Assert.AreEqual("Fifteen Love", score);
        }
    }
}