/*
Sep 10, 2023 23:24
Runtime 77 ms Beats 67.82%
Memory 38.1 MB Beats 71.26%
*/

public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        int[] combi = new int[target + 1];
        combi[0] = 1;
        for(int i = 1; i < combi.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if (i - nums[j] >= 0)
                    combi[i] += combi[i - nums[j]];
            }
        }
        return combi[target];
    }
}
