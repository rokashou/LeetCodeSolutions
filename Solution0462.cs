/*
Runtime: 84 ms, faster than 97.75% of C# online submissions for Minimum Moves to Equal Array Elements II.
Memory Usage: 40.8 MB, less than 6.74% of C# online submissions for Minimum Moves to Equal Array Elements II.
Uploaded: 06/30/2022 21:54
*/


public class Solution {
    public int MinMoves2(int[] nums) {
       int n = nums.Length, steps = 0;
        Array.Sort(nums);

        for(int i = 0; i < n / 2; i++) {
            steps += nums[n - 1 - i] - nums[i]; // Adding difference
        }

        return steps;


    }
}
