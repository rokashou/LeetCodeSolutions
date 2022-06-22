/*
Runtime: 141 ms, faster than 38.57% of C# online submissions for Kth Largest Element in an Array.
Memory Usage: 38.3 MB, less than 63.21% of C# online submissions for Kth Largest Element in an Array.
Uploaded: 06/22/2022 21:19	
*/


public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        Array.Sort<int>(nums);
        return nums[nums.Length - k];
    }
}
