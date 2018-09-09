namespace TennisGameSimple
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public string Score()
        {
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}