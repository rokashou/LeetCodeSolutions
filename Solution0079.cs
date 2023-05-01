/*
May 01, 2023 19:55
Runtime 359 ms Beats 64.11% 
Memory 40.6 MB Beats 64.91%

*/

public class Solution {
    private bool dfs(char[][] board, string word, int x, int y, int idx)
    {
        if (idx >= word.Length) return true;
        if (y < 0 || x < 0 || y == board.Length || x == board[y].Length) return false;
        if (board[y][x] != word[idx]) return false;
        board[y][x] = (char)(board[y][x] * -1);
        bool res = dfs(board, word, x + 1, y, idx + 1) ||
            dfs(board, word, x - 1, y, idx + 1) ||
            dfs(board, word, x, y + 1, idx + 1) ||
            dfs(board, word, x, y - 1, idx + 1);
        board[y][x] = (char)(board[y][x] * -1); 
        return res;
    }

    public bool Exist(char[][] board, string word)
    {
        for (int y = 0; y < board.Length; y++) {
            for (int x = 0; x < board[y].Length; x++) {
                if (dfs(board, word, x, y, 0)) return true;
            }
        }

        return false;
    }
}
