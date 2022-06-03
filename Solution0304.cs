/*
Runtime: 1819 ms, faster than 9.94% of C# online submissions for Range Sum Query 2D - Immutable.
Memory Usage: 91.2 MB, less than 27.48% of C# online submissions for Range Sum Query 2D - Immutable.
Uploaded: 06/03/2022 23:04
*/


public class NumMatrix {
    int[][] dp;

    public NumMatrix(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0) return;
        dp = new int[matrix.Length][];

        dp[0] = new int[matrix[0].Length];
        dp[0][0] = matrix[0][0];
        for(int c = 1; c < matrix[0].Length; c++)
        {
            dp[0][c] = matrix[0][c] + dp[0][c-1];
        }

        for(int r = 1; r < matrix.Length; r++)
        {
            dp[r] = new int[matrix[0].Length];
            dp[r][0] = dp[r - 1][0] + matrix[r][0];
            for(int c = 1; c < matrix[0].Length; c++)
            {
                dp[r][c] = dp[r][c-1] + dp[r-1][c] + matrix[r][c] - dp[r-1][c-1];
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        int sum = 0;
        sum += dp[row2][col2];
        if (row1 > 0)
            sum -= dp[row1 - 1][col2];
        if (col1 > 0)
            sum -= dp[row2][col1 - 1];
        if(row1>0 && col1 > 0)
            sum += dp[row1 - 1][col1 - 1];
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
