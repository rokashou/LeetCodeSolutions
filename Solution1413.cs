/*
Runtime: 76 ms, faster than 89.47% of C# online submissions for Minimum Value to Get Positive Step by Step Sum.
Memory Usage: 37.2 MB, less than 31.58% of C# online submissions for Minimum Value to Get Positive Step by Step Sum.
Uploaded: 11/11/2021 22:42	
*/

public class Solution {
    public int MinStartValue(int[] nums)
    {

        int result = 1;
        int total = result;
        int len = nums.Length;
        int idx = 0;

        while (idx < len)
        {
            total += nums[idx];
            if(total < 1)
            {
                idx = 0;
                result++;
                total = result;
            }
            else
            {
                idx++;
            }
        }

        return result;
    }
}
