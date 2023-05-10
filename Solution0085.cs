/*
May 10, 2023 15:00
Runtime 131 ms Beats 41.54%
Memory 48.2 MB Beats 90.77%
*/

public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        if (matrix == null || matrix.Length==0 || matrix[0] == null || matrix[0].Length == 0) return 0;
        int m = matrix.Length;
        int n = matrix[0].Length;
        int maxArea = 0;

        int[] left = new int[n];
        int[] right = new int[n];
        int[] height = new int[n];

        Array.Fill(right, n - 1);

        for(int i=0; i<m; i++)
        {
            int rB = n - 1;
            for(int j = n - 1; j >= 0; j--) {
                if (matrix[i][j] == '1')
                    right[j] = Math.Min(right[j], rB);
                else {
                    right[j] = n - 1;
                    rB = j - 1;
                }
            }
            int lB = 0;
            for(int j = 0; j < n; j++) {
                if (matrix[i][j] == '1') {
                    left[j] = Math.Max(left[j], lB);
                    height[j]++;
                    maxArea = Math.Max(maxArea, height[j] * (right[j] - left[j] + 1));
                }
                else {
                    height[j] = 0;
                    left[j] = 0;
                    lB = j + 1;
                }
            }
        }

        return maxArea;        
    }
}
