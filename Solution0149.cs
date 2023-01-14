/*
Runtime 104 ms, Beats 61.34%
Memory 47.9 MB, Beats 36.38%
Uploaded: Jan 14, 2023 22:55 CHT
*/


public class Solution {
    public int MaxPoints(int[][] points) {
        int n = points.Length;
        if (n == 1) return 1;

        int result = 2;
        for (int i = 0; i < n; i++)
        {
            var cnt = new Dictionary<double, int>();
            for (int j = 0; j < n; j++)
            {
                if (j != i)
                {
                    double atan = Math.Atan2(points[j][1] - points[i][1], points[j][0] - points[i][0]);
                    if (cnt.ContainsKey(atan))
                    {
                        cnt[atan] += 1;
                    }
                    else
                    {
                        cnt.Add(atan, 2);
                    }
                }
            }
            foreach (var value in cnt.Values)
            {
                result = Math.Max(result, value);
            }

        }
        return result;
    }
}
