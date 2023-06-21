/*
Jun 21, 2023 22:13
Runtime 154 ms Beats 100%
Memory 52.4 MB Beats 25%
*/


public class Solution {
    private long GetCost(int[] nums, int[] cost, int base_x)
    {
        long result = 0L;
        for(int i = 0; i < nums.Length; i++)
        {
            result += 1L * Math.Abs(nums[i] - base_x) * cost[i];
        }
        return result;
    }

    public long MinCost(int[] nums, int[] cost)
    {
        // Initialize the left and the right boundary of the binary search
        int left = 1000001, right = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            left = Math.Min(left, nums[i]);
            right = Math.Max(right, nums[i]);
        }
        long answer = GetCost(nums, cost, nums[0]);

        // As shown in the previous picture, if F(mid) > F(mid+1), then
        // the minimum is to the right of mid, otherwise, the minimum is
        // to the left of mid.
        while(left < right)
        {
            int mid = left + (right - left) / 2;
            long cost1 = GetCost(nums, cost, mid);
            long cost2 = GetCost(nums, cost, mid + 1);
            answer = Math.Min(cost1, cost2);

            if (cost1 > cost2)
                left = mid + 1;
            else
                right = mid;
        }

        return answer;
    }
}
