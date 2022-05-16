/*
Runtime: 186 ms, faster than 59.89% of C# online submissions for Shortest Path in Binary Matrix.
Memory Usage: 41.4 MB, less than 50.63% of C# online submissions for Shortest Path in Binary Matrix.
Uploaded: 05/17/2022 00:18
*/


public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length - 1;
        Queue<int> q = new Queue<int>();
        q.Enqueue(0);
        if (grid[0][0] == 1 || grid[n][n] == 1) return -1;
        grid[0][0] = 1;
        while(q.Count > 0)
        {
            int curr = q.Dequeue(), i = curr & (1 << 7) - 1, j = curr >> 7;
            if (i == n && j == n) return grid[n][n];
            for(int a = Math.Max(i - 1, 0); a <= Math.Min(i + 1, n); a++)
            {
                for(int b = Math.Max(j-1,0); b <= Math.Min(j+1,n); b++)
                {
                    if (grid[a][b] == 0)
                    {
                        grid[a][b] = grid[i][j] + 1;
                        q.Enqueue(a + (b << 7));
                    }
                }
            }
        }
        return -1;
    }
}

