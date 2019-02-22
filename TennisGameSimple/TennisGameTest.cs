using System;
using System.Collections.Generic;
using System.IO;
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

        [TestMethod]
        public void Fifteen_Love()
        {
            _game.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _game.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _game.Score();
            Assert.AreEqual(expected, score);
        }
    }

    public class TennisGame
    {
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {1, "Fifteen" },
            {2, "Thirty" },
        };

        public string Score()
        {
            if (_firstPlayerScore > 0)
            {
                return _scoreLookup[_firstPlayerScore] + " Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}
