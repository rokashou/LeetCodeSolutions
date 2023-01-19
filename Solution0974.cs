/*
Runtime 139 ms, Beats 82.86%
Memory 50.9 MB, Beats 25.71%
Accepted: Jan 19, 2023 19:28
*/

public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int n = nums.Length;
        int prefixMod = 0, result = 0;

        int[] modGroups = new int[k];
        modGroups[0] = 1;

        foreach(var num in nums)
        {
            // take module twice to avoid negative remainders.
            prefixMod = (prefixMod + num % k + k) % k;
            // add the count of subarrays that have the same remainder as the current
            // one to cancel out the remainders.
            result += modGroups[prefixMod];
            modGroups[prefixMod]++;
        }

        return result;

    }
}
