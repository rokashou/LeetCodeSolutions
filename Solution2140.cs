/*
May 12, 2023 18:20
Runtime 443 ms Beats 77.78%
Memory 64.1 MB Beats 100%
*/

public class Solution {
    public long MostPoints(int[][] questions) {
        long[] dp = new long[questions.Length];
        dp[questions.Length - 1] = questions[questions.Length - 1][0];
        for(int i = questions.Length-2; i >= 0; i--)
        {
            dp[i] = questions[i][0];
            int nextIndex = i + questions[i][1] + 1;
            if (nextIndex < questions.Length) {
                dp[i] += dp[nextIndex];
            }

            dp[i] = Math.Max(dp[i], dp[i + 1]);
        }
        return dp[0];
    }
}
