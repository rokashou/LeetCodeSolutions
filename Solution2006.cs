/*
Apr 09, 2023 20:59
Runtime 94 ms, Beats 70.87%
Memory 39.5 MB, Beats 72.82%
*/

public class Solution {
    public int CountKDifference(int[] nums, int k) {
        int count = 0;
        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                int delta = (nums[i] > nums[j]) ? (nums[i] - nums[j]) : (nums[j] - nums[i]);
                if (k == delta) count++;
            }
        }
        return count;
    }
}
