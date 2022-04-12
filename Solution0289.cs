/*
Runtime: 207 ms, faster than 35.55% of C# online submissions for Game of Life.
Memory Usage: 40.7 MB, less than 65.56% of C# online submissions for Game of Life.
Uploaded: 04/12/2022 20:23
*/


public class Solution {
    public void GameOfLife(int[][] board)
    {
        int i, j;
        int m = board.Length;
        int n = board[0].Length;
        for (i = 0; i < m; i++){
            for (j = 0; j < n;j++){
                int count = 0;
                if(i > 0){
                    if (j > 0) count += (board[i - 1][j - 1] > 0) ? 1 : 0;
                    count += (board[i - 1][j] > 0) ? 1 : 0;
                    if (j < n-1) count += (board[i - 1][j + 1] > 0) ? 1 : 0;
                }
                if(j>0) count += (board[i][j - 1] > 0) ? 1 : 0;
                if(j < n-1) count += (board[i][j + 1] > 0) ? 1 : 0;
                if(i < m-1){
                    if(j>0) count += (board[i + 1][j - 1] > 0) ? 1 : 0;
                    count += (board[i + 1][j] > 0) ? 1 : 0;
                    if(j<n-1) count += (board[i + 1][j + 1] > 0) ? 1 : 0;
                }
                int a = (board[i][j] == 0) ? (-1) : (1);
                if(count != 0)
                    board[i][j] = (count) * a;
            }
        }

        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                board[i][j] = JudgeLife(board[i][j]);
            }
        }

    }

    private int JudgeLife(int life){
        if(life > 0){
            if(life < 2) return 0;
            if(life > 3) return 0;
            return 1;
        }
        else
        {
            if(life == -3) return 1;
            return 0;
        }
    }
}
