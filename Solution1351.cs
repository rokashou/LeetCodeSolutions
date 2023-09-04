/*
Sep 04, 2023 17:13
Runtime 97 ms Beats 42.62%
Memory 43 MB Beats 26.16%
*/

public class Solution {
    public int CountNegatives(int[][] grid) {
        int i, n = grid.Length, j = grid[0].Length - 1, m = grid[0].Length, negativeCount = 0;
        for (i = 0; i < n; i++)
        {
            while (j >= 0 && grid[i][j] < 0) j--;
            if (j < 0)
              negativeCount += m;
            else if (j < m - 1)
              negativeCount += m - j - 1;
        }

        return negativeCount;
    }
}
