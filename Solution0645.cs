/*
Runtime: 171 ms, faster than 93.02% of C# online submissions for Set Mismatch.
Memory Usage: 51.1 MB, less than 17.44% of C# online submissions for Set Mismatch.
Uploaded: 10/23/2022 23:01
*/

public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int len = nums.Length;
        int total = (len + 1) * len / 2;
        int[] table = new int[len];
        int err = 0;
        for(int i = 0; i < len; i++)
        {
            if (table[nums[i]-1] == 0)
            {
                table[nums[i]-1] = 1;
                total -= nums[i];
            }

            else
            {
                err = nums[i];
            }
        }

        return new int[] { err, total };
    }
}
