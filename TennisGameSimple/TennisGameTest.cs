﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameSimple
{
    [TestClass]
    public class TennisGameTest
    {
        TennisGame _game = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _game.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _game.FirstPlayerScore();
            _game.FirstPlayerScore();
            ScoreShouldBe("Thirty Love");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _game.Score();
            Assert.AreEqual(expected, score);
        }
    }
}
