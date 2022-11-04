namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private int FirstPlayerScore;
        private int SecondPlayerScore;

        public void WonPoint(string playerName)
        {
            if (string.Equals(playerName, "player1"))
                FirstPlayerScore += 1;
            else
                SecondPlayerScore += 1;
        }

        public string GetScore()
        {
            if (FirstPlayerScore == SecondPlayerScore)
            {
                return HandleSameScore();
            }

            if (FirstPlayerScore >= 4 || SecondPlayerScore >= 4)
            {
                return HandleDeuceScore();
            }

            return HandleScore();
        }

        private string HandleScore() => TranslateScore(FirstPlayerScore) + "-" + TranslateScore(SecondPlayerScore);

        private static string TranslateScore(int intScore) =>
            intScore switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty",
                _ => ""
            };

        private string HandleDeuceScore() =>
            (FirstPlayerScore - SecondPlayerScore) switch
            {
                1 => "Advantage player1",
                -1 => "Advantage player2",
                >= 2 => "Win for player1",
                _ => "Win for player2"
            };

        private string HandleSameScore() =>
            FirstPlayerScore switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
    }
}

