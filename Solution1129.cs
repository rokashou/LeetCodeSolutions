/*
Runtime 170 ms, Beats 50%
Memory 46.8 MB, Beats 56.25%
Feb 11, 2023 12:39
Breadth-First Search
*/

public class Solution {
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges) {
        var adj = new Dictionary<int,List<int[]>>(); //(node, neighbor,color)
        foreach(var edge in redEdges)
        {
            if (!adj.ContainsKey(edge[0])) adj.Add(edge[0], new List<int[]>());
            adj[edge[0]].Add(new int[] { edge[1], 0 });
        }
        foreach(var edge in blueEdges)
        {
            if (!adj.ContainsKey(edge[0])) adj.Add(edge[0], new List<int[]>());
            adj[edge[0]].Add(new int[] { edge[1], 1 });
        }

        int[] answer = new int[n];
        Array.Fill(answer, -1);

        var visit = new bool[n, 2]; // node, color

        var queue = new Queue<int[]>(); // node, steps, previous color

        // Start with node 0, with number of steps as 0 and undefinded color -1.
        queue.Enqueue(new int[] { 0, 0, -1 });
        answer[0] = 0; // node 0 can reach node 0 with 0 steps
        visit[0, 1] = true; visit[0, 0] = true;

        while(queue.Count > 0)
        {
            var element = queue.Dequeue();
            int node = element[0], steps = element[1], prevColor = element[2];

            if (!adj.ContainsKey(node))
            {
                continue;
            }

            foreach(var nei in adj[node])
            {
                int neighbor = nei[0];
                int color = nei[1];
                if (!visit[neighbor,color] && color != prevColor)
                {
                    if (answer[neighbor] == -1)
                        answer[neighbor] = 1 + steps;
                    visit[neighbor, color] = true;
                    queue.Enqueue(new int[] { neighbor, 1 + steps, color });
                }
            }
        }

        return answer;
    }
}
