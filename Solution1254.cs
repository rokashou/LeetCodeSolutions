/*
Apr 06, 2023 23:05
Runtime 91 ms, Beats 89.86%
Memory 40.6 MB, Beats 94.20%
*/

public class Solution {
    public int ClosedIsland(int[][] grid) {
        var counter = 0;

        for (var i = 1; i < grid.Length -1; i++){
            for (var j = 1; j < grid[0].Length -1; j++){
                if (grid[i][j] == 0 && DFS(grid, i, j)) {
                    counter++;
                }
            }
        }

        return counter;
    }

    private bool DFS(int[][] grid, int i, int j) {
        if (grid[i][j] != 0) return true;
        grid[i][j] = 2;

        if (i == 0 || i == grid.Length - 1 || j == 0 || j == grid[0].Length - 1) return false;

        var res = DFS(grid, i - 1, j);
        res = DFS(grid, i + 1, j) && res;
        res = DFS(grid, i, j - 1) && res;
        res = DFS(grid, i, j + 1) && res;

        return res;
    }
}
