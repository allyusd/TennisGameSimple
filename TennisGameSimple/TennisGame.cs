﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameSimple
{
    class TennisGame
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };


        public string Score()
        {
            if (_firstPlayerScoreTimes != _secondPlayerScoreTimes)
            {
                return _scoreLookup[_firstPlayerScoreTimes] + " " + _scoreLookup[_secondPlayerScoreTimes];
            }

            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen All";
            }

            if (_firstPlayerScoreTimes == 2)
            {
                return "Thirty All";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}
