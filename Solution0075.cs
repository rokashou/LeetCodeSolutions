public class Solution {
    // Uploaded: 10/27/2021 23:07
    // Runtime: 124 ms, faster than 90.64% of C# online submissions for Sort Colors.
    // Memory Usage: 40.6 MB, less than 6.24% of C# online submissions for Sort Colors.
    public void SortColors(int[] nums)
    {
        if (nums.Length <= 1) return;

        int temp;
        int idx;
        int i, j;

        for (i = 0; i < nums.Length - 1; i++)
        {
            temp = nums[i];
            idx = i;
            for (j = i; j < nums.Length; j++)
            {
                if (nums[j] < temp)
                {
                    temp = nums[j];
                    idx = j;
                }
            }
            if (i < idx)
            {
                nums[idx] = nums[i];
                nums[i] = temp;
            }
        }
    }
}
