/*
Feb 11, 2023 14:43
Runtime 136 ms, Beats 95.35%
Memory 50.9 MB, Beats 72.9%
*/

public class Solution {
    public int MaxDistance(int[][] grid) {
        int rows = grid.Length, cols = grid[0].Length;
        int res = 0;

        // Maximum mangattan distance possible + 1.
        int MAX_DISTANCE = rows + cols + 1;

        // First pass: check for left and top neighbours
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    // Distance of land cells will be 0.
                    grid[i][j] = 0;
                }
                else
                {
                    grid[i][j] = MAX_DISTANCE;
                    // check left and top cell distances if they exist and update the current cell distance.
                    grid[i][j] = Math.Min(grid[i][j],Math.Min( i > 0 ? grid[i - 1][j] + 1 :MAX_DISTANCE, j > 0 ? grid[i][j-1] + 1 : MAX_DISTANCE));
                }
            }
        }

        // Second pass: check for right and bottom neighbours.
        int ans = int.MinValue;
        for(int i = rows - 1; i >= 0; i--)
        {
            for(int j = cols - 1; j >= 0; j--)
            {
                // check right and bottom cells distances if they exist and update the current cell distance.
                grid[i][j] = Math.Min(grid[i][j], Math.Min(i < rows - 1 ? grid[i + 1][j] + 1 : MAX_DISTANCE, j < cols - 1 ? grid[i][j + 1] + 1 : MAX_DISTANCE));
                ans = Math.Max(ans, grid[i][j]);
            }
        }

        // if ans is 1, it means there is no water cell
        // if ans is MAX_DISTANCE, it implies no land cell.
        return ans == 0 || ans == MAX_DISTANCE ? -1 : ans;
    }
}
