/*
Jul 05, 2023 21:34
Runtime 143 ms Beats 24.24%
Memory 51.1 MB Beats 32.90%
*/


public class Solution {
    public int LongestSubarray(int[] nums) {
        // Number of zero's in the window.
        int zeroCount = 0;
        int longestWindow = 0;
        // Left end of the window.
        int start = 0;

        for(int i = 0; i < nums.Length; i++) {
            zeroCount += (nums[i] == 0 ? 1 : 0);

            // Shrink the window until the zero counts come under the limit.
            while(zeroCount > 1) {
                zeroCount -= (nums[start] == 0 ? 1 : 0);
                start++;
            }

            longestWindow = Math.Max(longestWindow, i - start);
        }

        return longestWindow;
    }
}
