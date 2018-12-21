using System.Collections.Generic;

namespace TennisDay30
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _socreLookup = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public string Score()
        {
            if (_firstPlayerScoreTimes!=_secondPlayerScoreTimes)
            {
                return $"{_socreLookup[_firstPlayerScoreTimes]} {_socreLookup[_secondPlayerScoreTimes]}";
            }

            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen All";
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