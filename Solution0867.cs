/*
Runtime: 177 ms, faster than 67.19% of C# online submissions for Transpose Matrix.
Memory Usage: 45.9 MB, less than 73.44% of C# online submissions for Transpose Matrix.
Uploaded: 06/02/2022 20:04
*/

public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[][] result = new int[n][];
        for(int i = 0; i < n; i++) {
            int[] row = new int[m];
            for(int j = 0; j < m; j++)
            {
                row[j] = matrix[j][i];
            }
            result[i] = row;
        }
        return result;
    }
}
