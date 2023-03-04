/*
Runtime 199 ms, Beats 80%
Memory 53.8 MB, Beats 6.67%
Mar 04, 2023 12:47
*/

public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        // minPos, maxPos: the MOST RECENT positions of minK and maxK.
        // leftBound: the MOST RECENT value outside the range[minK,maxK].
        long count = 0;
        int minPos = -1, maxPos = -1, leftBound = -1;
        
        for (int i = 0; i < nums.Length; i++) {

            if (nums[i] < minK || nums[i] > maxK)
                leftBound = i;

            // if the number is minK or maxK, update the most recent position.
            if (nums[i] == minK)
                minPos = i;
            if (nums[i] == maxK)
                maxPos = i;

            // the number of valid subarrays equals the number of elements between leftBound and the smaller of the two most recent positions(minPos and maxPos).
            count += Math.Max(0, Math.Min(maxPos, minPos) - leftBound);

        }
        return count;
    }
}
