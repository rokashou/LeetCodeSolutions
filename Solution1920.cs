/*
Runtime: 235 ms, faster than 27.16% of C# online submissions for Build Array from Permutation.
Memory Usage: 45.7 MB, less than 55.42% of C# online submissions for Build Array from Permutation.
Uploaded: 05/22/2022 20:06
*/

public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] ans = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[nums[i]];
        }
        return ans;
    }
}
