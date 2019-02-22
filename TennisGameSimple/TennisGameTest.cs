using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameSimple
{
    [TestClass]
    public class TennisGameTest
    {
        [TestMethod]
        public void Love_All()
        {
            TennisGame game = new TennisGame();
            string score = game.Score();
            Assert.AreEqual("Love All", score);
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            throw new NotImplementedException();
        }
    }
}
