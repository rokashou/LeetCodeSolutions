/*
ChiaHsiang LU
submitted at May 03, 2024 02:46
Runtime 96 ms Beats 81.40% of users with C#
Memory 46.44 MB Beats 26.74% of users with C#
*/

public class Solution {
    public int FindMaxK(int[] nums) {
        HashSet<int> hash = new(nums);
        int max = -1;
        for(int i = 0; i < nums.Length; i++)
        {
            if (hash.Contains(nums[i] * -1))
            {
                max = Math.Max(max, Math.Abs(nums[i]));
            }
        }
        return max;        
    }
}
