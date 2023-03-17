/*
Mar 17, 2023 23:20
Runtime 77 ms, Beats 95.29%
Memory 38.4 MB, Beats 75.29%
*/

public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int count = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                if (nums[j] - nums[i] != diff) continue;
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[k] - nums[j] == diff) count++;
                }
            }
        }
        return count;
    }
}
