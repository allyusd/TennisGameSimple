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

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
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

            if (_firstPlayerScore == 1)
            {
                return "Fifteen Love";
            }

            if (_firstPlayerScore == 2)
            {
                return "Thirty Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}
