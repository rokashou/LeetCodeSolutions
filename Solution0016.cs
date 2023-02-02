/*
Runtime 119 ms, Beats 43.74%
Memory 39.7 MB, Beats 13.29%
Feb 02, 2023 22:23
*/

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort<int>(nums);
        int result = nums[0] + nums[1] + nums[2];
        int n = nums.Length;

        if (n == 3) return result;

        for(int i = 0; i <= n-3; i++)
        {
            int l = i + 1;
            int r = n - 1;
            while (l < r)
            {
                int tmpSum = nums[i] + nums[l] + nums[r];
                if(Math.Abs(target-result) >= Math.Abs(target - tmpSum))
                {
                    result = tmpSum;
                    if (result == target) return result;
                }
                if (tmpSum > target)
                    r--;
                else if (tmpSum < target)
                    l++;
            }
        }

        return result;
    }
}
