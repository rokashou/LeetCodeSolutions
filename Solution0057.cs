/*
Runtime 155 ms, Beats 82.46%
Memory 46 MB, Beats 39.69%
Accepted: Jan 16, 2023 21:48 CST
*/

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var ans = new List<int[]>();

        int i = 0;
        int start = newInterval[0];
        int end = newInterval[1];

        // Skip the intervals that smaller than newInterval
        while(i<intervals.Length && intervals[i][1] < start)
        {
            ans.Add(intervals[i]);
            i++;
        }

        // Merge the intervals overlap newInterval
        while(i<intervals.Length && intervals[i][0] <= end)
        {
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            i++;
        }

        ans.Add(new int[] { start, end });

        // Add remind intervals
        while (i < intervals.Length)
        {
            ans.Add(intervals[i]);
            i++;
        }

        return ans.ToArray();
    }
}
