/*
Runtime: 116 ms, faster than 40.70% of C# online submissions for Delete Operation for Two Strings.
Memory Usage: 36.8 MB, less than 84.88% of C# online submissions for Delete Operation for Two Strings.
Uploaded: 06/14/2022 23:19
*/

public class Solution {
    public int MinDistance(string word1, string word2) {
        int[] dp = new int[word2.Length + 1];
        for(int i = 0; i <= word1.Length; i++)
        {
            int[] temp = new int[word2.Length + 1];
            for(int j = 0; j <= word2.Length; j++)
            {
                if (i == 0 || j == 0)
                    temp[j] = i + j;
                else if (word1[i - 1] == word2[j - 1])
                    temp[j] = dp[j - 1];
                else
                    temp[j] = 1 + Math.Min(dp[j], temp[j - 1]);
            }
            dp = temp;
        }
        return dp[word2.Length];
    }
}
