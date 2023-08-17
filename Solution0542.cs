/*
Aug 17, 2023 22:06
Runtime 187 ms Beats 95.37%
Memory 69.5 MB Beats 17.13%
*/

public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        int INF = m + n;

        // scan from top-left
        for(int r = 0; r < m; r++)
        {
            for(int c = 0; c < n; c++)
            {
                if (mat[r][c] == 0) continue;
                int top = INF, left = INF;
                if (r - 1 >= 0) top = mat[r - 1][c];
                if (c - 1 >= 0) left = mat[r][c - 1];
                mat[r][c] = Math.Min(top, left) + 1;
            }
        }

        // scan from bottom-right
        for(int r=m-1;r>=0;r--)
            for(int c = n - 1; c >= 0; c--)
            {
                if (mat[r][c] == 0) continue;
                int btm = INF, right = INF;
                if (r + 1 < m) btm = mat[r + 1][c];
                if (c + 1 < n) right = mat[r][c + 1];
                mat[r][c] = Math.Min(mat[r][c], Math.Min(btm, right) + 1);
            }

        return mat;
    }
}
