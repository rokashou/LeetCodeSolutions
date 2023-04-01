/*
Mar 31, 2023 22:32
Runtime 96 ms, Beats 42.86%
Memory 38.5 MB, Beats 71.43%
*/


public class Solution
{
    private const int MOD = 1000000007;
    public int Ways(string[] pizza, int k)
    {
        int rows = pizza.Length, cols = pizza[0].Length;
        var apples = new int[rows + 1, cols + 1];
        var f = new int[rows, cols];
        for (int row = rows - 1; row >= 0; row--)
            for (int col = cols - 1; col >= 0; col--) {
                apples[row, col] = (pizza[row][col] == 'A' ? 1 : 0) + apples[row + 1, col] + apples[row, col + 1] - apples[row + 1, col + 1];
                f[row, col] = apples[row, col] > 0 ? 1 : 0;
            }

        for (int remain = 1; remain < k; remain++) {
            var g = new int[rows, cols];
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    for (int next_row = row + 1; next_row < rows; next_row++)
                    {
                        if (apples[row, col] - apples[next_row, col] > 0)
                        {
                            g[row, col] += f[next_row, col];
                            g[row, col] %= MOD;
                        }
                    }
                    for (int next_col = col + 1; next_col < cols; next_col++) {
                        if (apples[row, col] - apples[row, next_col] > 0)
                        {
                            g[row, col] += f[row, next_col];
                            g[row, col] %= MOD;
                        }
                    }

                }
            }
            // copy g to f
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    f[i, j] = g[i, j];
        }
        return f[0, 0];
    }
}
