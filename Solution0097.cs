/*
May 22, 2023 22:01
Runtime 83 ms Beats 45.97%
Memory 38 MB Beats 99.19%
*/

public class Solution {
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s3.Length != s1.Length + s2.Length) return false;

        var dp = new bool[s2.Length + 1];

        for (int i = 0; i <= s1.Length; i++)
            for(int j=0;j<=s2.Length;j++)
            {
                if (i == 0 && j == 0)
                    dp[j] = true;
                else if (i == 0)
                    dp[j] = dp[j - 1] && s2[j - 1] == s3[i + j - 1];
                else if (j == 0)
                    dp[j] = dp[j] && s1[i - 1] == s3[i + j - 1];
                else
                    dp[j] = (dp[j] && s1[i - 1] == s3[i+j-1]) || (dp[j-1] && s2[j - 1] == s3[i+j-1]);
            }

        return dp[s2.Length];
    }
}
