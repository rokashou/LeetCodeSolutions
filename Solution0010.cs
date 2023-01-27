/*
Runtime 101 ms, Beats 59.15%
Memory 37.8 MB, Beats 88.36%
Accepted: Jan 27, 2023 18:56
Approach: Dynamic Programming Bottom-Up
*/

public class Solution {
    public bool IsMatch(string s, string p) {
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        dp[s.Length, p.Length] = true;

        for(int i=s.Length; i>=0; --i)
        {
            for(int j = p.Length - 1; j >= 0; --j)
            {
                bool first_match = (i < s.Length && (p[j] == s[i] || p[j] == '.'));
                if(j+1 < p.Length && p[j+1] == '*')
                {
                    dp[i, j] = dp[i, j + 2] || first_match && dp[i + 1, j];
                }
                else
                {
                    dp[i, j] = first_match && dp[i + 1, j + 1];
                }
            }
        }

        return dp[0,0];
    }
}
