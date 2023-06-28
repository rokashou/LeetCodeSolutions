/*
Official Solution: Bellman-Ford Algorithm
Jun 28, 2023 23:38
Runtime 221 ms Beats 100%
Memory 56 MB Beats 68.42%
*/

public class Solution {
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end) {
        double[] maxProb = new double[n];
        maxProb[start] = 1.0;

        for(int i = 0; i < n - 1; i++) {
            bool hasUpdate = false;
            for(int j=0;j<edges.Length; j++) {
                int u = edges[j][0];
                int v = edges[j][1];
                double pathProb = succProb[j];
                if (maxProb[u] * pathProb > maxProb[v]) {
                    maxProb[v] = maxProb[u] * pathProb;
                    hasUpdate = true;
                }
                if (maxProb[v] * pathProb > maxProb[u]) {
                    maxProb[u] = maxProb[v] * pathProb;
                    hasUpdate = true;
                }
            }
            if (!hasUpdate) break;
        }

        return maxProb[end];
    }
}
