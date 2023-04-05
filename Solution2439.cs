/*
Official Solution
Apr 05, 2023 09:49
Runtime 218 ms, Beats 87.50%
Memory 55.5 MB, Beats 31.25%
*/


public class Solution {
    public int MinimizeArrayValue(int[] nums) {
        long answer = 0, prefixSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            answer = Math.Max(answer, (prefixSum + i) / (i + 1));
        }

        return (int)answer;
    }
}
