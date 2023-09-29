/*
Sep 30, 2023 00:24
Runtime 242 ms Beats 37.50%
Memory 61.2 MB Beats 68.30%
My solution
*/


public class Solution {
    public bool IsMonotonic(int[] nums) {
        int status = 0;

        for(int i = 1; i < nums.Length; i++)
        {
            switch (status)
            {
                case 0:
                    if (nums[i - 1] > nums[i])
                        status = 2; // decrease
                    else if (nums[i - 1] < nums[i])
                        status = 1; // increase
                    break;
                case 1: // increase
                    if (nums[i - 1] > nums[i])
                        return false;
                    break;
                case 2: // decrease
                    if (nums[i - 1] < nums[i])
                        return false;
                    break;
            }
        }
        return true;

    }
}
