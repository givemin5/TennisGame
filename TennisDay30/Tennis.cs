﻿using System.Collections.Generic;

namespace TennisDay30
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _socreLookup = new Dictionary<int,string>
        {
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" },
        };

        public string Score()
        {
            if (_secondPlayerScoreTimes==1)
            {
                return "Love Fifteen";
            }
            if (_secondPlayerScoreTimes==2)
            {
                return "Love Thirty";
            }
            if (_firstPlayerScoreTimes>0)
            {
                return $"{_socreLookup[_firstPlayerScoreTimes]} Love";
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