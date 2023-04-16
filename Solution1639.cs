/*
Apr 16, 2023 14:53
Runtime 148 ms Beats 50%
Memory 60.8 MB Beats 83.33%
*/

public class Solution
{
    public int NumWays(string[] words, string target)
    {
        const long mod = 1_000_000_007;

        int m = target.Length;
        int n = words[0].Length;

        if (m > n)  {
            return 0;
        }

        long[,] count = new long[26, n];

        foreach (string word in words) {
            for (int j = 0; j < n; j++) {
                count[word[j] - 'a', j]++;
            }
        }

        long[,] dp = new long[m, n];

        dp[0, 0] = count[target[0] - 'a', 0];
        for (int j = 1; j < n; j++) {
            dp[0, j] = (dp[0, j - 1] + count[target[0] - 'a', j]) % mod;
        }

        for (int i = 1; i < m; i++) {
            for (int j = i; j < n; j++) {
                dp[i, j] = (dp[i, j - 1] + count[target[i] - 'a', j] * dp[i - 1, j - 1]) % mod;
            }
        }

        return (int)dp[m - 1, n - 1];
    }
}
