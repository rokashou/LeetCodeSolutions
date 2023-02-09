/*
Runtime 139 ms, Beats 94.32%
Memory 44.6 MB, Beats 64.7%
Feb 09, 2023 22:45
*/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        int[] ans = new int[] {-1,-1};
        if (nums.Length == 0) return ans;
        // find left
        while (l < r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] < target)
            {
                l = m + 1;
            }
            else if (nums[m] >= target)
            {
                r = m;
            }
        }
        if (nums[l]==target)
            ans[0] = l;
        if (ans[0] == -1) return ans;
        // reset r bound
        r = nums.Length - 1;

        
        while (l <= r)
        {
            int m = l + (r - l) / 2;
            if (nums[m] <= target)
            {
                l = m + 1;
            }
            else if (nums[m] > target)
            {
                r = m - 1;
            }
        }
        ans[1] = r;

        return ans;
    }
}
