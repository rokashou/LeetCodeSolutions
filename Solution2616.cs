/*
Aug 09, 2023 20:11
Runtime 168 ms Beats 100%
Memory 57.3 MB Beats 50%
*/

public class Solution {
    public int MinimizeMax(int[] nums, int p)
    {
        Array.Sort(nums);

        int n = nums.Length;
        int left = 0, right = nums[n - 1] - nums[0];

        while(left < right)
        {
            int mid = left + (right - left) / 2;

            // If there are enough pairs, look for a smaller threshold.
            // Otherwise, look for a larger threshold.
            if (CountValidPairs(nums, mid) >= p)
                right = mid;
            else
                left = mid + 1;
        }

        return left;

    }

    private int CountValidPairs(int[] nums, int threshold)
    {
        int index = 0, count = 0;
        while(index < nums.Length - 1)
        {
            if (nums[index+1] - nums[index] <= threshold)
            {
                count++;
                index++;
            }
            index++;
        }
        return count;
    }
}
