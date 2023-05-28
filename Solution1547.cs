/*
May 28, 2023 20:52
Runtime 105 ms Beats 60%
Memory 39.5 MB Beats 100%
*/

public class Solution {
    public int MinCost(int n, int[] cuts) {
        int m = cuts.Length;
        var newCuts = new int[m + 2];
        Array.Copy(cuts, 0, newCuts, 1, m);
        newCuts[m + 1] = n;
        Array.Sort(newCuts);

        var dp = new int[m + 2,m + 2];
        for(int diff = 2; diff < m + 2; ++diff)
        {
            for(int left = 0; left < m + 2 - diff; ++left)
            {
                int right = left + diff;
                int ans = int.MaxValue;
                for(int mid = left + 1; mid < right; ++mid)
                {
                    ans = Math.Min(ans, dp[left, mid]+ dp[mid, right] + newCuts[right] - newCuts[left]);
                }
                dp[left, right] = ans;
            }
        }

        return dp[0, m + 1];        
    }
}
