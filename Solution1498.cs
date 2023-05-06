/*
May 06, 2023 09:06
Runtime 222 ms Beats 66.67%
Memory 52.9 MB Beats 100%
*/

public class Solution {
    public int NumSubseq(int[] nums, int target) {
        int n = nums.Length;
        int MOD = 1_000_000_007;
        Array.Sort(nums);
        int[] power = new int[n];
        power[0] = 1;
        for (int i = 1; i < n; i++)
            power[i] = (power[i - 1] * 2) % MOD;

        int answer = 0;
        int left = 0, right = n - 1;
        while (left <= right)
        {
            if (nums[left] + nums[right] <= target)
            {
                answer += power[right - left];
                answer %= MOD;
                left++;
            }
            else
                right--;
        }

        return answer;
    }
}
