namespace TennisGameSimple
{
    public class TennisGame
    {
        private int m_firstPlayerScoreTimes;

        public string Score()
        {
            if (m_firstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }

            if (m_firstPlayerScoreTimes == 2)
            {
                return "Thirty Love";
            }

            if (m_firstPlayerScoreTimes == 3)
            {
                return "Forty Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            m_firstPlayerScoreTimes++;
        }
    }
}
