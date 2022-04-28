
/*
Runtime: 347 ms, faster than 58.46% of C# online submissions for Path With Minimum Effort.
Memory Usage: 51.8 MB, less than 26.15% of C# online submissions for Path With Minimum Effort.
Uploaded: 04/28/2022 21:20
*/

public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        int[] dirs = new int[] { 0, 1, 0, -1, 0 };

        int r = heights.Length;
        int c = heights[0].Length;
        bool[,] visited = new bool[r, c];
        var pq = new SortedSet<(int H, int X, int Y)>();
        pq.Add((0, 0, 0));
        while(pq.Count > 0)
        {
            var cur = pq.Min;
            if (cur.X == r - 1 && cur.Y == c - 1) return cur.H;
            visited[cur.X, cur.Y] = true;
            pq.Remove(cur);
            for(int d = 0; d < 4; d++)
            {
                int nx = cur.X + dirs[d];
                int ny = cur.Y + dirs[d + 1];
                if (nx < 0 || nx == r || ny < 0 || ny == c || visited[nx, ny]) continue;
                int nh = Math.Max(cur.H, Math.Abs(heights[cur.X][cur.Y] - heights[nx][ny]));
                pq.Add((nh, nx, ny));
            }
        }
        return 0;
    }
}

