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
            var score = game.Score();
            Assert.AreEqual("Love All", score);
        }
    }
}
