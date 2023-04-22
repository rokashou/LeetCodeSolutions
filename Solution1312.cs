/*
Apr 22, 2023 11:25
Runtime 62 ms Beats 100%
Memory 36.1 MB Beats 100%
*/

public class Solution {
    public int MinInsertions(string s) {
        int n = s.Length;

        var sReverse = s.ToCharArray();
        Array.Reverse(sReverse);

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

        return n - dp[n - 1];
    }
}


/*
Apr 22, 2023 10:59
Runtime 88 ms Beats 64.52%
Memory 36 MB Beats 100%
*/


public class Solution {
    public int MinInsertions(string s)
    {
        int n = s.Length;

        var ar = s.ToCharArray();
        Array.Reverse(ar);
        string sReverse = new string(ar);

        return n - LongestCommonSubSequence(s, sReverse, n, n);
        
    }

    private int LongestCommonSubSequence(string s1, string s2, int m, int n)
    {
        var dp = new int[n + 1];
        var dpPrev = new int[n + 1];

        for(int i = 0; i <= m; i++)
        {
            for(int j = 0; j <= n; j++)
            {
                if(i==0 || j == 0)
                {
                    // one of the two strings is empty.
                    dp[j] = 0;
                }
                else if (s1[i - 1] == s2[j - 1])
                {
                    dp[j] = 1 + dpPrev[j - 1];
                }
                else
                {
                    dp[j] = Math.Max(dpPrev[j], dp[j - 1]);
                }
            }

            Array.Copy(dp, dpPrev, n + 1);
        }

        return dp[n];
    }
    
}
