/*
Official Solution
Apr 09, 2023 19:07
Runtime 528 ms, Beats 100%
Memory 103.4 MB, Beats 66.67%
*/


public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
        int n = colors.Length;
        var adj = new Dictionary<int, List<int>>();
        var indegree = new int[n];

        foreach(var e in edges)
        {
            if (!adj.ContainsKey(e[0]))
                adj.Add(e[0], new List<int>());
            adj[e[0]].Add(e[1]);
            indegree[e[1]]++;
        }

        var count = new int[n,26];
        var q = new Queue<int>();

        // Push all the nodes with indegree zero in the queue
        for(int i = 0; i < n; i++)
            if (indegree[i] == 0) q.Enqueue(i);

        int answer = 1, visited = 0;
        while (q.Count > 0)
        {
            int node = q.Dequeue();
            answer = Math.Max(answer, ++count[node, colors[node] - 'a']);
            visited++;

            if (!adj.ContainsKey(node))
                continue;

            foreach(var neighbor in adj[node])
            {
                for(int i = 0; i < 26; i++)
                {
                    // Try to update the frequency of colors for the neighbor to include paths that use node->neighbor edge.
                    count[neighbor, i] = Math.Max(count[neighbor, i], count[node, i]);
                }

                indegree[neighbor]--;
                if (indegree[neighbor] == 0)
                {
                    q.Enqueue(neighbor);
                }
            }
        }

        return visited < n ? -1 : answer;
    }
}
