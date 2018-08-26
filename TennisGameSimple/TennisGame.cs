using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameSimple
{
    class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private string _firstPlayerName;
        private string _secondPlayerName;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
        };

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            this._firstPlayerName = firstPlayerName;
            this._secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            return IsScoreDifferent()
                ? (IsReadyForWin() ? AdvState() : NormalScore())
                : (IsDeuce() ? Deuce() : SameScore());
        }

        private string SameScore()
        {
            return _scoreLookup[_firstPlayerScore] + " All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScore != _secondPlayerScore;
        }

        private string NormalScore()
        {
            return _scoreLookup[_firstPlayerScore] + " " + _scoreLookup[_secondPlayerScore];
        }

        private string AdvState()
        {
            return AdvPlayer() + (IsAdv() ? " Adv" : " Win");
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private string AdvPlayer()
        {
            var advPlayer = _firstPlayerScore > _secondPlayerScore
                ? _firstPlayerName
                : _secondPlayerName;
            return advPlayer;
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
