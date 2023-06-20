/*
Jun 20, 2023 21:44
Runtime 443 ms Beats 25%
Memory 60.6 MB Beats 83.93%
*/

public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        int[] ans = new int[nums.Length];
        long total = 0;

        Array.Fill(ans, -1);
        int totalcnt = k * 2 + 1;
        int i = 0;

        if (k == 0) return nums;
        if (totalcnt > nums.Length) return ans;

        for(; i < totalcnt; i++)
        {
            total += nums[i];
        }
        ans[k] = (int)(total / totalcnt);

        for (; i < nums.Length; i++)
        {
            total = total - nums[i - totalcnt] + nums[i];
            ans[i-k] = (int)(total / totalcnt);
        }

        return ans;
    }
}
