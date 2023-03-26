/*
Mar 26, 2023 15:33
Runtime 132 ms, Beats 87.50%
Memory 42.6 MB, Beats 93.75%
*/

public class Solution {
    public int[] ProcessQueries(int[] queries, int m)
    {
        var P = new List<int>();
        for (int i = 0; i < m; i++)
            P.Add(i + 1);

        var ans = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            ans[i] = P.IndexOf(queries[i]);
            P.Remove(queries[i]);
            P.Insert(0, queries[i]);
        }

        return ans;
    }
}
