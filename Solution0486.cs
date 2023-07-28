/*
Dynamic Programming with space optimized.
Jul 28, 2023 17:40

Runtime 70 ms Beats 100%
Memory 40.1 MB Beats 54.55%
*/

public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        Array.Copy(nums, dp, n);

        for(int dif = 1; dif < n; ++dif) {
            for(int left = 0; left < n - dif; left++) {
                int right = left + dif;
                dp[left] = Math.Max(nums[left] - dp[left + 1], nums[right] - dp[left]);
            }
        }

        return dp[0] >= 0;        
    }
}
