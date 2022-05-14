/*
Runtime: 193 ms, faster than 84.01% of C# online submissions for Network Delay Time.
Memory Usage: 52.3 MB, less than 8.46% of C# online submissions for Network Delay Time.
Uploaded: 05/14/2022 23:31
*/

public class Solution {

    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        // implementation of Belman-Ford Algorithm
        // http://www.youtube.com/watch?v=FtN38YH2Zes
        // run relaxation of each vertex exactly n-1 times
        // source vertex should have 0 cost to visit, all other vertexes should start from infinity cost
        var costs = new Dictionary<int, double>();
        for (int i = 1; i <= n; i++)
            costs[i] = double.PositiveInfinity;
        costs[k] = 0;

        int u, v, w;

        for (int i = 0; i < n - 1; i++)
        {
            bool isRelaxed = false;
            for (int t = 0; t < times.Length; t++)
            {
                u = times[t][0];
                v = times[t][1];
                w = times[t][2];

                double candidateCost = costs[u] + w;
                if (costs[v] > candidateCost)
                {
                    costs[v] = candidateCost;
                    isRelaxed = true;
                }
            }

            if (!isRelaxed)
                break;
        }

        double maxCost = double.NegativeInfinity;
        foreach(var co in costs)
        {
            maxCost = Math.Max(maxCost, co.Value);
        }

        return (maxCost < double.PositiveInfinity) ? (int)maxCost : -1;
    }
    
}
