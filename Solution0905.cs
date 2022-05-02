/*
Runtime: 148 ms, faster than 82.68% of C# online submissions for Sort Array By Parity.
Memory Usage: 46.4 MB, less than 13.78% of C# online submissions for Sort Array By Parity.
Uploaded: 05/02/2022 10:53
*/

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int l=0,r=nums.Length-1,swap;
        while (l < r)
        {
            // find the even number on left
            while (l < r && nums[l] % 2 == 0) l++;
            // find the odd number on right
            while (l < r && nums[r] % 2 == 1) r--;
            // swap the number in array
            if (l != r)
            {
                swap = nums[l];
                nums[l] = nums[r];
                nums[r] = swap;
                l++;
                r--;
            }
        }
        return nums;

    }
}
