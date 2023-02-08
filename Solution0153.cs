/*
Feb 09, 2023 00:03
Runtime 86 ms, Beats 74.62%
Memory 38.9 MB, Beats 39.30%
*/


public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        while (l < r)
        {
            int m = l + (r - l) / 2;

            if (nums[l] < nums[r]) // normal sorted list
            {
                if (nums[l] <= nums[m])
                    r = m-1;
                else
                    l = m;
            }
            else // nums[l] > nums[r], aka rotated list
            {
                if (nums[m] < nums[r])
                {
                    r = m;
                }
                else
                    l = m + 1;
            }
        }
        return nums[l];
    }
}
