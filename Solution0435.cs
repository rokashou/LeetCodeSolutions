/*
Jul 19, 2023 21:58
Runtime 435 ms Beats 54.50%
Memory 72.7 MB Beats 83.78%
*/

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort<int[]>(intervals, (x, y) => (x[1] - y[1]));

        int ans = 0;
        int k = int.MinValue;

        for(int i = 0; i < intervals.Length; i++) {
            int x = intervals[i][0];
            int y = intervals[i][1];
            if (x >= k)
                k = y;
            else
                ans++;
        }
        return ans;

    }
}
