/*
Sep 24, 2023 23:19
Runtime 19 ms Beats 91.67%
Memory 52.6 MB Beats 5.56%
*/

public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        double[,] A = new double[102,102];
        A[0, 0] = (double)poured;
        for(int r = 0; r <= query_row; r++)
        {
            for(int c = 0; c<=r; c++)
            {
                double q = (A[r, c] - 1.0) / 2.0;
                if(q > 0)
                {
                    A[r + 1, c] += q;
                    A[r + 1, c + 1] += q;
                }
            }
        }
        return Math.Min(1, A[query_row, query_glass]);
    }
}
