/*
Feb 08, 2023 23:18
Runtime 77 ms, Beats 97.56%
Memory 39.2 MB, Beats 23.90%
*/

public class Solution {
    public int Search(int[] nums, int target)
    {
        int largestIndex = GetLargestIndex(nums);
        int left = 0;
        int right = nums.Length - 1;
        // if target is small than nums[0], search (LargestIndex, end)
        if(target < nums[0])
        {
            left = largestIndex + 1;
        }
        // if target is bigger than nums[0], search (0,LargestIndex)
        else if(target >= nums[0])
        {
            right = largestIndex;
        }
        return SearchInRange(nums, left, right, target);
        
    }

    private int SearchInRange(int[] nums, int left, int right, int target)
    {
        while (left <= right)
        {
            int m = left + (right - left) / 2;
            if (nums[m] == target)
                return m;
            else if (nums[m] > target)
                right = m - 1;
            else
                left = m + 1;
        }
        return -1;
    }

    private int GetLargestIndex(int[] nums)
    {
        int l = 0;
        int r = nums.Length-1;
        while (l < r) {
            int m = l + (r - l) / 2;

            if (nums[l] < nums[m])
            {
                l = m;
            }
            else if (nums[m] < nums[r]) { 
                if (nums[l] > nums[r])
                {
                    r = m-1;
                }
                else
                {
                    l = m + 1;
                }
            }
            else
                r=m;
        }
        return l;
    }
}
