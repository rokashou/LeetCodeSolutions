/*
Runtime 151 ms, Beats 100%
Memory 46.2 MB, Beats 100%
Feb 27, 2023 22:50
*/

public class Solution {
    public int[] LeftRigthDifference(int[] nums) {
        int[] ans = new int[nums.Length];

        int leftSum = 0;
        int rightSum = 0;
        for (int i = 1; i < nums.Length; i++) 
            rightSum += nums[i];

        ans[0] = rightSum;
        for (int i = 1; i < nums.Length; i++) {
            rightSum -= nums[i];
            leftSum += nums[i - 1];
            ans[i] = Math.Abs(leftSum - rightSum);
        }
        return ans;

    }
}
