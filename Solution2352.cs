/*
Jun 13, 2023 23:04
Runtime 222 ms Beats 23.28%
Memory 61 MB Beats 13.79%
*/

public class Solution {
    public int EqualPairs(int[][] grid)
    {
        int n = grid.Length;
        var dicCol = new Dictionary<string, int>();
        var dicRow = new Dictionary<string, int>();
        var tcol = new int[n];
        var trow = new int[n];

        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++)
            {
                tcol[j] = grid[i][j];
                trow[j] = grid[j][i];
            }
            string scol = ArrayString(tcol);
            string srow = ArrayString(trow);
            if (!dicCol.ContainsKey(scol))
                dicCol[scol] = 0;
            dicCol[scol] += 1;
            if (!dicRow.ContainsKey(srow))
                dicRow[srow] = 0;
            dicRow[srow] += 1;
        }
        int ans = 0;
        foreach(var k in dicCol.Keys)
        {
            if (dicRow.ContainsKey(k))
                ans += dicCol[k] * dicRow[k];
        }

        return ans;
    }

    public string ArrayString(int[] input)
    {
        var result = new System.Text.StringBuilder();
        result.AppendJoin(',', input);
        return result.ToString();
    }
}
