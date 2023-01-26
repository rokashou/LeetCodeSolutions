/*
Runtime 112 ms, Beats 64.58%
Memory 40.1 MB, Beats 93.75%
Accepted: Jan 26, 2023 12:35
*/

public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        int[] cost = new int[n];
        Array.Fill(cost, int.MaxValue);
        cost[src] = 0;
        for(int i = 0; i <= k; i++)
        {
            int[] tmp = new int[n];
            cost.CopyTo(tmp, 0);
            foreach(var f in flights)
            {
                int curr = f[0], next = f[1], price = f[2];
                if (cost[curr] == int.MaxValue) continue;
                tmp[next] = Math.Min(tmp[next], cost[curr] + price);
            }
            cost = tmp;
        }
        return cost[dst] == int.MaxValue ? -1 : cost[dst];
    }
}
