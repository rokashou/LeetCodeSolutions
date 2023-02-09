/*
Runtime 163 ms Beats 83.25%
Memory 43.7 MB, Beats 56.16%
Feb 10, 2023 00:34
Backtracking
*/

public class Solution {
    public void SolveSudoku(char[][] board)
    {
        var list = new List<int[]>();
        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                if (board[i][j]=='.') list.Add(new int[]{i,j});
            }
        }
        solve(board, list, 0);
    }

    private bool solve(char[][] board, List<int[]> pos, int cur)
    {
        if (cur >= pos.Count)
            return true;

        int x = pos[cur][0], y = pos[cur][1];
        for(int i = 0; i < 9; i++)
        {
            int ok = 1;
            char c = (char)('1' + i);
            for(int j = 0; j < 9; j++)
            {
                if (board[x][j] == c || board[j][y] == c) { ok = 0; break; }
            }
            int xs = x / 3 * 3, ys = y / 3 * 3;
            for (int sx = 0; sx < 3; ++sx)
                for (int sy = 0; sy < 3; ++sy)
                    if (board[sx + xs][sy + ys] == c) 
                        ok = 0;
            if (ok > 0)
            {
                board[x][y] = c;
                if (solve(board, pos, cur + 1)) return true;
                board[x][y] = '.';
            }
        }
        return false;
    }
}
