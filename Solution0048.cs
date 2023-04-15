/*
Apr 15, 2023 19:33
Runtime 147 ms Beats 40.22%
Memory 42.8 MB Beats 8.94%
*/

public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length-1;

        for(int x = 0; x <= n/2; x++)
        {
            for(int y=x; y<n-x; y++)
            {
                var tmp = matrix[n - y][x];
                matrix[n - y][x] = matrix[n - x][n - y];
                matrix[n - x][n - y] = matrix[y][n - x];
                matrix[y][n - x] = matrix[x][y];
                matrix[x][y] = tmp;
            }
        }

    }
}
