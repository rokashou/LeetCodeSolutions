/*
Apr 22, 2023 11:13
Runtime 77 ms Beats 96.59%
Memory 36.2 MB Beats 97.38%
*/

public class Solution {
    public int LongestPalindromeSubseq(string s) {
        var n = s.Length;
        var dp = new int[n];
        var dpPrev = new int[n];

        for (var i = n - 1; i >= 0; --i)
        {
            dp[i] = 1;
            for (var j = i + 1; j < n; ++j)
            {                    
                if (s[i] == s[j])
                    dp[j] = dpPrev[j - 1] + 2;
                else
                    dp[j] = Math.Max(dpPrev[j], dp[j - 1]);
            }
            dp.CopyTo(dpPrev, 0);
        }
        
        return dp[n - 1];
    }
}
