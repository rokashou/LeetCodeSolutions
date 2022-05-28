/*
Runtime: 107 ms, faster than 84.92% of C# online submissions for Missing Number.
Memory Usage: 44.2 MB, less than 5.66% of C# online submissions for Missing Number.
Uploaded: 05/28/2022 19:03
*/

public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort<int>(nums);

        int i = 0;
        for(; i < nums.Length; i++)
        {
            if (nums[i] != i) break;
        }

        return i;
    }
}
