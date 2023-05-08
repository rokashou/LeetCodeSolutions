/*
May 08, 2023 11:14
Runtime 94 ms Beats 80.49%
Memory 42.4 MB Beats 7.32%
*/

public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum = 0;
        int n = mat.Length-1;
        for(int i = 0; i <= n; i++)
        {
            // primary
            sum += mat[i][i];

            // secondary
            if (i != n - i) sum += mat[i][n - i];
        }
        return sum;
        
    }
}
