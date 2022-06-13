/*
Runtime: 160 ms, faster than 19.49% of C# online submissions for Triangle.
Memory Usage: 38.3 MB, less than 58.46% of C# online submissions for Triangle.
Uploaded: 06/13/2022 21:55
*/

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int[] dp = new int[triangle.Count];
        int[] dp1 = new int[triangle.Count];
        // Remember base case is just returning leaf nodes
        for(int i = 0; i < triangle.Count; i++)
        {
            dp[i] = triangle[triangle.Count - 1][i];
        }

        for(int row = triangle.Count - 2; row >= 0; row--)
        {
            for(int pos = 0;pos < triangle[row].Count; pos++)
            {
                dp1[pos] = triangle[row][pos] + Math.Min(dp[pos + 1], dp[pos]);
            }
            dp = dp1;
        }

        return dp[0];
    }
}
