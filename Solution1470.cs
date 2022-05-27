/*
Runtime: 165 ms, faster than 66.46% of C# online submissions for Shuffle the Array.
Memory Usage: 43 MB, less than 94.21% of C# online submissions for Shuffle the Array.
Uploaded: 05/27/2022 20:37
*/


public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] result = new int[nums.Length];
        for(int i = 0; i < n; i++)
        {
            result[i * 2] = nums[i];
            result[i * 2 + 1] = nums[i + n];
        }
        return result;
    }
}
