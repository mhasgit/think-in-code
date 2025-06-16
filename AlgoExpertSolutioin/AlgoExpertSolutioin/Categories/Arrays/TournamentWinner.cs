using System.Security.Principal;

namespace AlgoExpertSolution.Categories.Arrays
{
    public class TournamentWinner
    {
        private const int HOME_TEAM_WON = 1;
        private const int POINTS_FOR_WIN = 3;

        public static string Solve(List<List<string>> competitions, List<int> results)
        {
            string currentBestTeam = string.Empty;

            var scores = new Dictionary<string, int>
            {
                [currentBestTeam] = 0
            };

            for (int i = 0; i < competitions.Count; i++)
            {
                var competition = competitions[i];
                string homeTeam = competition[0];
                string awayTeam = competition[1];

                int result = results[i];

                string winningTeam = result == HOME_TEAM_WON ? homeTeam : awayTeam;

                UpdateScores(winningTeam, POINTS_FOR_WIN, scores);

                if (scores[winningTeam] > scores[currentBestTeam])
                {
                    currentBestTeam = winningTeam;
                }

            }

            return currentBestTeam;
        }

        public static void UpdateScores(string team, int points, Dictionary<string, int> score)
        {
            if (!score.ContainsKey(team))
            {
                score[team] = 0;
            }
            score[team] += points;
        }
    }
}
