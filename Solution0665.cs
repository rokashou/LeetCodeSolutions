/*
Runtime: 233 ms, faster than 5.81% of C# online submissions for Non-decreasing Array.
Memory Usage: 42.5 MB, less than 52.33% of C# online submissions for Non-decreasing Array.
Uploaded: 06/25/2022 18:12
*/


public class Solution {
    public bool CheckPossibility(int[] nums) {
        int cnt = 0;
        for(int i = 1; i < nums.Length && cnt <= 1; i++)
        {
            if (nums[i - 1] > nums[i]) {
                cnt++;
                if (i - 2 < 0 || nums[i - 2] <= nums[i]) nums[i - 1] = nums[i];
                else nums[i] = nums[i - 1];
            }
        }
        return cnt <= 1;
    }
}
