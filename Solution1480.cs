/*
Runtime: 156 ms, faster than 73.42% of C# online submissions for Running Sum of 1d Array.
Memory Usage: 41.7 MB, less than 51.79% of C# online submissions for Running Sum of 1d Array.
Uploaded: 05/26/2022 20:10
*/

public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] runningSum = new int[nums.Length];
        runningSum[0] = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            runningSum[i] = runningSum[i - 1] + nums[i];
        }
        return runningSum;
    }
}
