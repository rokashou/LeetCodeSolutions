/*
Apr 05, 2023 13:38
Runtime 136 ms, Beats 100%
Memory 49.6 MB, Beats 34.43%
*/

public class Solution {
    private int LargestLocalNumber(int[][] grid,int x, int y)
    {
        int max = grid[x][y];
        for(int i = x-1; i <= x+1 && i < grid.Length; i++) {
            if (i<0) i += 1;
            for(int j = y - 1; j <= y + 1; j++)
            {
                if (j < 0) j += 1;
                max = Math.Max(max, grid[i][j]);
            }
        }
        return max;
    }

    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        var ans = new int[n - 2][];
        
        for(int i = 0; i < n - 2; i++)
        {
            ans[i] = new int[n-2];
            for(int j = 0; j < n - 2; j++)
            {
                ans[i][j] = LargestLocalNumber(grid, i + 1, j + 1);
            }
        }

        return ans;
    }
}
