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

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            m_firstPlayerScoreTimes++;
        }
    }
}
