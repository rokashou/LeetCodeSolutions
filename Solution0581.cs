/*
Runtime: 174 ms, faster than 25.49% of C# online submissions for Shortest Unsorted Continuous Subarray.
Memory Usage: 39.7 MB, less than 96.08% of C# online submissions for Shortest Unsorted Continuous Subarray.
Uploaded: 05/03/2022 15:04
*/

public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        if(nums.Length <= 1) return 0;
        
        int min = int.MaxValue;
        int max = int.MinValue;
        bool flag = false;

        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
                flag = true;
            if (flag)
                min = Math.Min(min, nums[i]);
        }

        flag = false;
        for(int i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] > nums[i + 1])
                flag = true;
            if (flag)
                max = Math.Max(max, nums[i]);
        }

        int l, r;
        for (l = 0; l < nums.Length; l++)
            if (min < nums[l]) break;
        for (r = nums.Length-1; r >= 0; r--)
            if (max > nums[r]) break;
        return r - l < 0 ? 0 : r - l + 1;

    }
}
