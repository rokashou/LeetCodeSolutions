/*
Aug 31, 2023 00:35
Runtime 172 ms Beats 66.67%
Memory 48.6 MB Beats 66.67%
*/

public class Solution {
    public long MinimumReplacement(int[] nums) {
        long answer = 0;
        int n = nums.Length;

        // Start from the second last element, as the last one is always sorted.
        for(int i = n - 2; i >= 0; i--)
        {
            // no need to break if they are already in order
            if (nums[i] <= nums[i + 1]) continue;

            // count how many elements are made from breaking nums[i].
            long numElements = (long)(nums[i] + nums[i + 1] - 1) / (long)nums[i + 1];

            // It requires numElements - 1 replacement operations.
            answer += numElements - 1;

            // Maximize nums[i] after replacement.
            nums[i] = nums[i] / (int)numElements;
        }

        return answer;
    }
}
