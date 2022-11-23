/*
Runtime: 114 ms, faster than 93.17% of C# online submissions for Valid Sudoku.
Memory Usage: 44.7 MB, less than 17.18% of C# online submissions for Valid Sudoku.
Uploaded: 11/23/2022 20:45
*/



public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int x = 0; x < 9; x++)
        {
            for(int y = 0; y < 9; y++)
            {
                char curr = board[x][y];
                if (curr == '.') continue;

                // check in horital and vertial
                for(int v = 0; v < 9; v++)
                {
                    if (v != y && board[x][v] == curr) return false;
                    if (v != x && board[v][y] == curr) return false;
                }

                // check 3x3
                int xbase = x - (x % 3);
                int ybase = y - (y % 3);
                for(int i=0;i<3;i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        if (i + xbase == x && j + ybase == y) continue;
                        if (board[xbase + i][ybase + j] == curr) return false;
                    }
                }

            }
        }

        return true;

    }
}

