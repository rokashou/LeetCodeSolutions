/*
Runtime 148 ms, Beats 49.82%
Memory 43.3 MB, Beats 31.64%
Accepted Feb 07, 2023 00:18
*/

public class Solution {
    public void NextPermutation(int[] nums) {
        // Actually "check next permutation in dictionary order"
        for(int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i - 1] < nums[i])
            {
                int j = nums.Length - 1;
                while (nums[i - 1] >= nums[j]) j--;
                int tmp = nums[i - 1];
                nums[i - 1] = nums[j];
                nums[j] = tmp;
                Array.Reverse<int>(nums, i, nums.Length - i);
                return;
            }
        }
        Array.Reverse<int>(nums);
        return;

    }
}
