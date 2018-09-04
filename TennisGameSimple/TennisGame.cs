namespace TennisGameSimple
{
    public class TennisGame
    {
        private int m_firstPlayerScoreTimes;

        public string Score()
        {
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            m_firstPlayerScoreTimes++;
        }
    }
}
