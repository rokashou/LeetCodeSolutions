/*
Aug 31, 2023 21:25
Runtime 82 ms Beats 100%
Memory 42 MB Beats 83.33%    
*/

public class Solution {
    public int MinTaps(int n, int[] ranges) {
        // Create an array to track the maximum reach for each position
        int[] maxReach = new int[n + 1];

        // Calculate the maximum reach for each tap
        for(int i = 0; i < ranges.Length; i++)
        {
            // Calculate the leftmost position the tap can reach
            int start = Math.Max(0, i - ranges[i]);
            // Calculate the rightmost position the tap can reach
            int end = Math.Min(n, i + ranges[i]);

            // Update the maximum reach for the leftmost position
            maxReach[start] = Math.Max(maxReach[start], end);
        }

        // Number of taps used
        int taps = 0;
        // current rightmost position reached
        int currEnd = 0;
        // Next rightmost postion that can be reached
        int nextEnd = 0;

        // Iterate through the garden
        for(int i = 0; i <= n; i++)
        {
            // Current postion cannot be reached
            if (i > nextEnd) return -1;

            // Increment taps when moving to a new tap
            if (i > currEnd)
            {
                taps++;
                // Move to the rightmost position that can be reached
                currEnd = nextEnd;
            }

            // Update the next rightmost position that can be reached
            nextEnd = Math.Max(nextEnd, maxReach[i]);
        }

        // Return the minimum number of taps used;
        return taps;
    }
}
