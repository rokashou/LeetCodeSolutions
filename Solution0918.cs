/*
Runtime 158 ms, Beats 68.75%
Memory 52.1 MB, Beats 32.81%
Accepted: Jan 18, 2023 20:26
*/

public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int curMax = nums[0], curMin = nums[0];
        int sum = nums[0], maxSum = nums[0], minSum = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            curMax = Math.Max(curMax + nums[i], nums[i]);
            maxSum = Math.Max(maxSum, curMax);
            curMin = Math.Min(curMin + nums[i], nums[i]);
            minSum = Math.Min(minSum, curMin);
            sum += nums[i];
        }
        return sum == minSum ? maxSum : Math.Max(maxSum, sum - minSum);
    }
}
