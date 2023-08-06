/*
Aug 06, 2023 14:36
Runtime 30 ms Beats 71.43%
Memory 28.6 MB Beats 85.71%
*/

public class Solution 
{
    const int M = 1_000_000_007;

    public int NumMusicPlaylists(int n, int L, int k) 
    {
        var dp = new long[L + 1, n + 1];
        dp[0, 0] = 1;

        for (int i = 1; i <= L; i++)
            for (int j = 1; j <= n; j++)
            {
                dp[i, j] = (dp[i - 1, j - 1] * (n - j + 1)) % M;
                dp[i, j] = (dp[i, j] + (dp[i - 1, j] * Math.Max(j - k, 0) % M)) % M;
            }

        return (int)dp[L, n];
    }
}
