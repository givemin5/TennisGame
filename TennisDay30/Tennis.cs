using System.Collections.Generic;

namespace TennisDay30
{
    public class Tennis
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _socreLookup = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (IsScoreDifferent())
            {
                if (_firstPlayerScoreTimes>3)
                {
                    if (_firstPlayerScoreTimes-_secondPlayerScoreTimes==1)
                    {
                        return $"{_firstPlayerName} Adv";
                    }
                }

                return LookupScore();
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        private string LookupScore()
        {
            return $"{_socreLookup[_firstPlayerScoreTimes]} {_socreLookup[_secondPlayerScoreTimes]}";
        }

        private string SameScore()
        {
            return $"{_socreLookup[_firstPlayerScoreTimes]} All";
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