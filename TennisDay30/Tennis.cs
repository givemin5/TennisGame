using System.Collections.Generic;

namespace TennisDay30
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;

        public string Score()
        {
            var socreLookup = new Dictionary<int,string>
            {
                {1,"Fifteen" },
                {2,"Thirty" },
            };

            if (_firstPlayerScoreTimes == 1||_firstPlayerScoreTimes==2)
            {
                return $"{socreLookup[_firstPlayerScoreTimes]} Love";
            }


            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}