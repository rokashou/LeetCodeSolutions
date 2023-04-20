/*
Apr 20, 2023 23:19
Runtime 140 ms Beats 98.22%
Memory 48.7 MB Beats 31.4%
*/


public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        HashSet<int> rows = new HashSet<int>(); 
        HashSet<int> cols = new HashSet<int>();
        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                if(matrix[i][j] == 0) {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }

        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                if(rows.Contains(i) || cols.Contains(j)) {
                    matrix[i][j] = 0;
                }
            }
        }
    }

    private void SetRowZeroes(int[][] matrix, int rowIndex, int columnLength)
    {
        for(int i = 0; i < columnLength; i++) {
            matrix[rowIndex][i] = 0;
        }
    }

    private void SetColumnZeroes(int[][] matrix, int columnIndex, int rowLength)
    {
        for(int i = 0; i < rowLength; i++) {
            matrix[i][columnIndex] = 0;
        }
    }
}
