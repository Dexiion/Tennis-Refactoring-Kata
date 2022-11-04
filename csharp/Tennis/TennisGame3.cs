namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int Player2Score;
        private int Player1Score;
        private readonly string Player1Name;
        private readonly string Player2Name;
        private readonly string[] Words = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame3(string player1Name, string player2Name)
        {
            Player1Name = player1Name;
            Player2Name = player2Name;
        }

        public string GetScore()
        {
            if (Player1Score < 4 && Player2Score < 4 && Player1Score + Player2Score < 6)
            {
                return HandleScore();
            }

            return Player1Score == Player2Score ? "Deuce" : HandleAdvantageScore();
        }

        private string HandleAdvantageScore()
        {
            var winningPlayer = Player1Score > Player2Score ? Player1Name : Player2Name;
            return (Player1Score - Player2Score) * (Player1Score - Player2Score) == 1
                ? "Advantage " + winningPlayer
                : "Win for " + winningPlayer;
        }

        private string HandleScore()
        {
            var score = Words[Player1Score];
            return Player1Score == Player2Score ? score + "-All" : score + "-" + Words[Player2Score];
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                Player1Score += 1;
            else
                Player2Score += 1;
        }

    }
}

