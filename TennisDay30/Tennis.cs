using System;
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
                if (IsReadyForGamePoint())
                {
                    if (IsAdv())
                    {
                        var advPlayer = AdvPlayer();
                        return $"{advPlayer} Adv";
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

        private bool IsReadyForGamePoint()
        {
            return _firstPlayerScoreTimes>3||_secondPlayerScoreTimes>3;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes-_secondPlayerScoreTimes)==1;
        }

        private string AdvPlayer()
        {
            var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes
                ? _firstPlayerName
                : _secondPlayerName;
            return advPlayer;
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