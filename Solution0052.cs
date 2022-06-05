/*
Runtime: 39 ms, faster than 48.30% of C# online submissions for N-Queens II.
Memory Usage: 25.9 MB, less than 37.29% of C# online submissions for N-Queens II.
Uploaded: 06/05/2022 12:52
*/

public class Solution {
    private IList<IList<string>> res;
    private char[][] chess;

    private void solve(int row)
    {
        if (row == chess.Length)
        {
            res.Add(construct());
            return;
        }
        for (int col = 0; col < chess.Length; col++)
        {
            if (valid(row, col))
            {
                chess[row][col] = 'Q';
                solve(row + 1);
                chess[row][col] = '.';
            }
        }
    }
    private bool valid(int row, int col)
    {
        // check all cols
        for (int i = 0; i < row; i++)
            if (chess[i][col] == 'Q') return false;
        // check 45 degree
        for (int i = row - 1, j = col + 1; i >= 0 && j < chess.Length; i--, j++)
            if (chess[i][j] == 'Q') return false;
        // check 135 degree
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            if (chess[i][j] == 'Q') return false;

        return true;
    }

    private List<string> construct()
    {
        List<string> path = new List<string>();
        for (int i = 0; i < chess.Length; i++)
        {
            path.Add(new string(chess[i]));
        }
        return path;
    }

    public int TotalNQueens(int n)
    {
        chess = new char[n][];
        for (int i = 0; i < n; i++)
        {
            chess[i] = new char[n];
            for (int j = 0; j < n; j++)
            {
                chess[i][j] = '.';
            }
        }
        res = new List<IList<string>>();

        solve(0);

        return res.Count;
    }
}
