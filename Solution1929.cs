/*
Runtime: 305 ms, faster than 5.25% of C# online submissions for Concatenation of Array.
Memory Usage: 45.6 MB, less than 44.63% of C# online submissions for Concatenation of Array.
Uploaded: 05/22/2022 20:02
*/

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];
        for(int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }
        return ans;
    }
}

