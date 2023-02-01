/*
Runtime 150 ms, Beats 100%
Memory 44.8 MB, Beats 75%
Accepted: Feb 01, 2023 21:26
*/

public class Solution {
    public int BestTeamScore(int[] scores, int[] ages)
    {
        int n = ages.Length;
        List<int[]> ageScorePair = new List<int[]>();

        for (int i = 0; i < n; i++)
        {
            ageScorePair.Add(new int[] { ages[i], scores[i] });
        }

        // Sort in ascending order of age and then by score.
        ageScorePair.Sort((a, b) => (a[0] == b[0] ? a[1] - b[1] : a[0] - b[0]));

        int answer = 0;
        int[] dp = new int[n];

        // Initially, the maximum score for each player will be equal to the individual scores.
        for (int i = 0; i < n; i++)
        {
            dp[i] = ageScorePair[i][1];
            for (int j = i - 1; j >= 0; j--)
            {
                // if the players j and i count be in the same team.
                if (ageScorePair[i][1] >= ageScorePair[j][1])
                {
                    // Update the maximum score for the ith player.
                    dp[i] = Math.Max(dp[i], ageScorePair[i][1] + dp[j]);
                }
            }
            // Maximum score among all the players.
            answer = Math.Max(answer, dp[i]);
        }

        return answer;
    }
}
