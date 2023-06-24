/*
Jun 24, 2023 21:23
Runtime 111 ms Beats 75%
Memory 56.3 MB Beats 75%
*/

public class Solution {
    public int TallestBillboard(int[] rods) {
        int n = rods.Length;
        int sum = rods.Sum();
        int[] dp = new int[2 * sum + 1];
        Array.Fill(dp, -1);
        dp[sum] = 0;
        
        for (int i = 0; i < n; i++) {
            int[] next = (int[])dp.Clone();
            
            for (int j = 0; j <= 2 * sum; j++) {
                if (dp[j] < 0) continue;
                
                // Case 1: Not using the current rod
                next[j] = Math.Max(next[j], dp[j]);
                
                // Case 2: Adding the current rod to the taller side
                int taller = j - rods[i];
                if (taller >= 0) {
                    next[taller] = Math.Max(next[taller], dp[j] + rods[i]);
                }
                
                // Case 3: Adding the current rod to the shorter side
                int shorter = j + rods[i];
                if (shorter <= 2 * sum) {
                    next[shorter] = Math.Max(next[shorter], dp[j]);
                }
            }
            
            dp = next;
        }
        
        return dp[sum];
    }
}
