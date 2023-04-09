/*
The Best Solution
Kind of DFS
Apr 09, 2023 19:51
Runtime 159 ms, Beats 88.58%
Memory 60.7 MB, Beats 46.91%
*/

public class Solution {
    public int NumEnclaves(int[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if ((i == 0 || j == 0 || i == grid.Length - 1 || j == grid[i].Length - 1) && grid[i][j] == 1) //if cell is boundary and land
                {
                    VisitLands(grid, i, j);
                }
            }

        }
        count = grid.Sum(row => row.Count(cell => cell == 1));
        return count;
    }
    private void VisitLands(int[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length) return;
        if (grid[i][j] == 0) { return; }
        grid[i][j] = 0;
        VisitLands(grid, i + 1, j);
        VisitLands(grid, i - 1, j);
        VisitLands(grid, i, j + 1);
        VisitLands(grid, i, j - 1);
    }
}


/*
Depth-First Search
Apr 09, 2023 19:48
Runtime 199 ms, Beats 9.88%
Memory 63.6 MB, Beats 9.57%
*/

public class Solution {
    private void dfs(int x, int y, int m, int n, int[][] grid, bool[,] visit)
    {
        if(x<0 || x >= m || y < 0 || y >= n || grid[x][y] == 0 || visit[x, y])
            return;

        visit[x, y] = true;
        var dirx = new int[] { 0, 1, 0, -1 };
        var diry = new int[] { -1, 0, 1, 0 };
        for(int i = 0; i < 4; i++)
            dfs(x + dirx[i], y + diry[i], m, n, grid, visit);

        return;
    }

    public int NumEnclaves(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        var visit = new bool[m, n];

        for(int i = 0; i < m; i++)
        {
            // First column.
            if (grid[i][0] == 1 && !visit[i, 0])
                dfs(i, 0, m, n, grid, visit);
            // Last column.
            if (grid[i][n - 1] == 1 && !visit[i, n - 1])
                dfs(i, n - 1, m, n, grid, visit);
        }

        for(int i = 0; i < n; i++)
        {
            // First row
            if (grid[0][i] == 1 && !visit[0, i])
                dfs(0, i, m, n, grid, visit);
            // Last row
            if (grid[m - 1][i] == 1 && !visit[m - 1, i])
                dfs(m - 1, i, m, n, grid, visit);
        }

        int count = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (grid[i][j] == 1 && !visit[i, j])
                    count++;

        return count;
    }
}
