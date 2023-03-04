/*
Runtime 139 ms, Beats 69.34%
Memory 51.1 MB, Beats 5.92%
Mar 04, 2023 13:08
*/

public class Solution {
    bool feasible(int[] weights, int c, int days)
    {
        int daysNeeded = 1, currentLoad = 0;
        foreach (var w in weights)
        {
            currentLoad += w;
            if (currentLoad > c)
            {
                daysNeeded++;
                currentLoad = w;
            }
        }

        return daysNeeded <= days;
    }

    public int ShipWithinDays(int[] weights, int days)
    {
        int totalLoad = 0, maxLoad = 0;
        foreach (var w in weights)
        {
            totalLoad += w;
            maxLoad = Math.Max(maxLoad, w);
        }

        int l = maxLoad, r = totalLoad;

        while (l < r) {
            int mid = l + (r - l) / 2;
            if (feasible(weights, mid, days))
                r = mid;
            else
                l = mid + 1;
        }
        return l;
    }
}
