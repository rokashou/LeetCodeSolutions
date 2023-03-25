/*
Mar 25, 2023 09:20
Runtime 436 ms, Beats 68.89%
Memory 74.1 MB, Beats 37.78%
*/

public class Solution {
    private int count = 0;

    private void Bfs(int node, int n, Dictionary<int, List<int[]>> adj)
    {
        var q = new Queue<int>();
        bool[] visit = new bool[n];
        q.Enqueue(node);
        visit[node] = true;

        while (q.Count > 0)
        {
            node = q.Dequeue();
            if (!adj.ContainsKey(node))
                continue;

            foreach (var nei in adj[node])
            {
                int neighbor = nei[0];
                int sign = nei[1];
                if (!visit[neighbor])
                {
                    count += sign;
                    visit[neighbor] = true;
                    q.Enqueue(neighbor);
                }
            }
        }
    }

    public int MinReorder(int n, int[][] connections)
    {
        var adj = new Dictionary<int, List<int[]>>(); // as (node -> child)
        foreach (var conn in connections)
        {
            adj.TryAdd(conn[0], new List<int[]>());
            adj[conn[0]].Add(new int[] { conn[1], 1 }); // child = {node, direction}
            adj.TryAdd(conn[1], new List<int[]>());
            adj[conn[1]].Add(new int[] { conn[0], 0 });
        }
        Bfs(0, n, adj);
        return count;
    }
}

