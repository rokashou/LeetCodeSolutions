/*
May 11, 2023 21:28
Runtime 100 ms Beats 50%
Memory 40.9 MB Beats 56.25%
*/

public class Solution {
    public int MaxUncrossedLines(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;

        int[,] dp = new int[n1 + 1, n2 + 1];

        for(int i=1;i<=n1;i++)
            for(int j = 1; j <= n2; j++)
            {
                if (nums1[i - 1] == nums2[j - 1])
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                else
                    dp[i, j] = Math.Max(dp[i,j - 1], dp[i - 1,j]);
            }

        return dp[n1, n2];        
    }
}
