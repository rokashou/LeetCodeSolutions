/*
Feb 09, 2023 21:30
Runtime 85 ms, Beats 89.53%
Memory 39.4 MB, Beats 59.30%
*/

public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        while (l < r)
        {
            // skips left repeats
            while (l<r && nums[l] == nums[l + 1]) l++;
            // skips right repeats
            while (l<r && nums[r] == nums[r - 1]) r--;
            // skips if nums[left] == nums[right];
            while (l<r && nums[l] == nums[r]) r--;

            if(l>=r) break;

            int m = l + (r - l) / 2;

            if (nums[l] < nums[r]) // normal sorted list
            {
                if (nums[l] <= nums[m])
                    r = m - 1;
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
