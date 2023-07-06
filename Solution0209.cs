/*
Jul 06, 2023 21:57
Runtime 133 ms Beats 28.29%
Memory 47.1 MB Beats 77.41%
*/

public class Solution {
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0, right = 0, sum = 0;
        int res = int.MaxValue;

        for(right = 0; right < nums.Length; right++) {
            sum += nums[right];

            while(sum >= target) {
                res = Math.Min(res, right - left + 1);
                sum -= nums[left++];
            }
        }

        return res == int.MaxValue ? 0 : res;
    }
}
