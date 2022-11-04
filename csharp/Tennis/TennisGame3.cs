namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int Player2Score;
        private int Player1Score;
        private string Player1Name;
        private string Player2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            Player1Name = player1Name;
            Player2Name = player2Name;
        }

        public string GetScore()
        {
            string score;
            if (Player1Score < 4 && Player2Score < 4 && Player1Score + Player2Score < 6)
            {
                string[] words = { "Love", "Fifteen", "Thirty", "Forty" };
                score = words[Player1Score];
                return Player1Score == Player2Score ? score + "-All" : score + "-" + words[Player2Score];
            }

            if (Player1Score == Player2Score)
                return "Deuce";
            score = Player1Score > Player2Score ? Player1Name : Player2Name;
            return (Player1Score - Player2Score) * (Player1Score - Player2Score) == 1 ? "Advantage " + score : "Win for " + score;
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

