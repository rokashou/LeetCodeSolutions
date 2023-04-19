/*
Apr 19, 2023 20:58
Runtime 59 ms Beats 95.56%
Memory 43.4 MB Beats 35.38%
*/

public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;
        int[][] dp = new int[m + 1][];
        for (int w1 = 0; w1 <= m; w1++)
        {
            dp[w1] = new int[n + 1];
            dp[w1][n] = m - w1;
        }

        for (int w2 = 0; w2 < n; w2++)
        {
            dp[m][w2] = n - w2;
        }

        for (int w1 = m - 1; w1 >= 0; w1--)
        {
            for (int w2 = n - 1; w2 >= 0; w2--)
            {
                if (word1[w1] == word2[w2])
                {
                    dp[w1][w2] = dp[w1 + 1][w2 + 1];
                    continue;
                }

                dp[w1][w2] = Math.Min(dp[w1 + 1][w2 + 1], Math.Min(dp[w1][w2 + 1], dp[w1 + 1][w2])) + 1;
            }
        }

        return dp[0][0];
    }
}


/*
Top-Down DP
Apr 19, 2023 20:38
Runtime 66 ms Beats 81.93%
Memory 44.4 MB Beats 18.38%
*/

public class Solution {
    int?[,] memo;
    // Memoization: Top-Down DP
    public int MinDistance(string word1, string word2)
    {
        memo = new int?[word1.Length + 1, word2.Length + 1];
        return MinDistanceRecur(word1, word2, word1.Length, word2.Length);
    }

    private int MinDistanceRecur(string word1, string word2, int word1Index, int word2Index)
    {
        if (word1Index == 0) return word2Index;
        if (word2Index == 0) return word1Index;
        if (memo[word1Index, word2Index] != null)
        {
            return memo[word1Index, word2Index].Value;
        }
        int minEditDistance = 0;
        if (word1[word1Index-1] == word2[word2Index - 1])
        {
            minEditDistance = MinDistanceRecur(word1, word2, word1Index - 1, word2Index - 1);
        }
        else
        {
            int insertOperation = MinDistanceRecur(word1, word2, word1Index, word2Index - 1);
            int deleteOperation = MinDistanceRecur(word1, word2, word1Index - 1, word2Index);
            int replaceOperation = MinDistanceRecur(word1, word2, word1Index - 1, word2Index - 1);
            minEditDistance = Math.Min(insertOperation, Math.Min(deleteOperation, replaceOperation)) + 1;
        }
        memo[word1Index, word2Index] = minEditDistance;
        return minEditDistance;
    }
}
