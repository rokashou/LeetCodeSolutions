/*
Sep 18, 2023 00:22
Runtime 80 ms Beats 100%
Memory 40 MB Beats 83.33%
*/


public class Solution {
    public int ShortestPathLength(int[][] graph) {
        int n = graph.Length;
        Queue<(int, int, int)> q = new Queue<(int, int, int)>();
        bool[,] visited = new bool[n, 1 << n];

        for (int i = 0; i < n; i++) {
            q.Enqueue((i, 1 << i, 0));
            visited[i, 1 << i] = true;
        }

        while (q.Count > 0) {
            var (node, mask, distance) = q.Dequeue();
            
            if (mask == (1 << n) - 1) {
                return distance;
            }

            foreach (int nextNode in graph[node]) {
                int nextMask = mask | (1 << nextNode);
                if (!visited[nextNode, nextMask]) {
                    q.Enqueue((nextNode, nextMask, distance + 1));
                    visited[nextNode, nextMask] = true;
                }
            }
        }

        return -1;
    }
}
