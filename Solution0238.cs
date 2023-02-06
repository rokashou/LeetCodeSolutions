/*
Runtime 168 ms, Beats 87.52%
Memory 53.9 MB, Beats 44.89%
Accept Feb 07, 2023 00:52
*/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        // initial
        Array.Fill(result, 1);
        int fromBegin = 1;
        int fromEnd = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            result[i] *= fromBegin;
            fromBegin *= nums[i];
            result[nums.Length - 1 - i] *= fromEnd;
            fromEnd *= nums[nums.Length - 1 - i];
        }

        return result;
    }
}

