using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameSimple
{
    [TestClass]
    public class TennisGameTest
    {
        private readonly TennisGame _game = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _game.Score();
            Assert.AreEqual(expected, score);
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            return "Love All";
        }
    }
}
