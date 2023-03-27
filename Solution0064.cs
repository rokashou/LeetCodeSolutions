/*
Mar 27, 2023 22:26
Runtime 97 ms, Beats 52.58%
Memory 40.1 MB, Beats 85.92%
*/

public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int[] cur = new int[m];
        Array.Fill(cur, grid[0][0]);
        
        for (int i = 1; i < m; i++)
            cur[i] = cur[i - 1] + grid[i][0];
        for (int j = 1; j < n; j++)
        {
            cur[0] += grid[0][j];
            for(int i=1;i<m;i++)
                cur[i] = Math.Min(cur[i-1],cur[i]) + grid[i][j];
        }
        return cur[m - 1];
    }
}

