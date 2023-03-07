/*
Mar 08, 2023 00:17
Runtime 413 ms, Beats 83.33%
Memory 54.9 MB, Beats 55.56%
*/

public class Solution {
    private bool IsTimeEnough(int[] time, long givenTime, int totalTrips)
    {
        long actualTrips = 0;
        foreach (var t in time)
        {
            actualTrips += givenTime / t;
            if (actualTrips > totalTrips) return true;

        }

        return actualTrips >= totalTrips;
    }

    public long MinimumTime(int[] time, int totalTrips)
    {
        int max_time = 0;
        foreach (int t in time) max_time = Math.Max(max_time, t);
        long left = 1, right = (long)max_time * totalTrips;

        // Binary search to find the minimum time to finish the task.
        while (left < right)
        {
            long mid = left + (right - left) / 2;
            if (IsTimeEnough(time, mid, totalTrips))
                right = mid;
            else
                left = mid + 1;
        }
        return left;
    }
}
