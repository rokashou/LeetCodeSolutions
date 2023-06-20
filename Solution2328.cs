/*
Jun 20, 2023 22:05
Runtime 300 ms Beats 73.73%
Memory 55.5 MB Beats 82.20%
*/


public class Solution {
    int[,] dp;
    int[,] directions = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
    int mod = 1_000_000_007;

    int dfs(int[][] grid, int i, int j)
    {
        // if dp[i,j] is non-zero, it means we have got the value of dfs(i,j),
        // so just return dp[i,j]
        if (dp[i, j] != 0) return dp[i, j];

        // otherwise, set answer = 1, the path mode of grid[i,j] itself.
        int answer = 1;

        // check its four neighbor cells, if a neighbor cell grid[pi,pj] has a
        // smaller value, we move to this cell and solve the subproblem: dfs(pi,pj)
        for(int idx = 0; idx < 4; idx++)
        {
            int pi = i + directions[idx, 0], pj = j + directions[idx, 1];
            if(0<=pi && pi<grid.Length &&
                0<=pj && pj < grid[0].Length && grid[pi][pj] < grid[i][j])
            {
                answer += dfs(grid, pi, pj);
                answer %= mod;
            }
        }

        // update dp[i,j], so that we don't recalculate its value later.
        dp[i, j] = answer;
        return answer;
    }

    public int CountPaths(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        dp = new int[m, n];

        // Iterate over all cells grid[i][j] and sum over dfs(i,j).
        int answer = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                answer = (answer + dfs(grid, i, j)) % mod;

        return answer;
    }
}
