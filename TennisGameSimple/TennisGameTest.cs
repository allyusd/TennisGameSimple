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

        [TestMethod]
        public void Forty_Love()
        {
            GivenFirstPlayerScoreTimes(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _game.SecondPlayerScore();
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            GivenFirstPlayerScoreTimes(1);
            GivenSecondPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScoreTimes(2);
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_when_4_4()
        {
            GivenFirstPlayerScoreTimes(4);
            GivenSecondPlayerScoreTimes(4);
            ScoreShouldBe("Deuce");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _game.FirstPlayerScore();
            }
        }
        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _game.SecondPlayerScore();
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
        private int _secondPlayerScore;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };


        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                if (_firstPlayerScore > 0)
                {
                    return _scoreLookup[_firstPlayerScore] + " Love";
                }

                if (_secondPlayerScore > 0)
                {
                    return "Love " + _scoreLookup[_secondPlayerScore];
                }
            }

            if (_firstPlayerScore >= 3)
            {
                return "Deuce";
            }

            return _scoreLookup[_firstPlayerScore] + " All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}
