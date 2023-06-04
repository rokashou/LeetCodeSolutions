/*
Jun 04, 2023 22:38
Runtime 111 ms Beats 99.49%
Memory 47.9 MB Beats 57.95%
*/

public class Solution 
{
    public int MaximumDetonation(int[][] bombs)
    {
        int result = 0, n = bombs.Length;
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i < n; ++i)
        {
            graph.Add(new List<int>());
            long x = bombs[i][0], y = bombs[i][1], r2 = (long)bombs[i][2] * bombs[i][2];
            for (int j = 0; j < n; ++j)
                if ((x - bombs[j][0]) * (x - bombs[j][0]) + (y - bombs[j][1]) * (y - bombs[j][1]) <= r2)
                    graph[i].Add(j);
        }
        for (int i = 0; i < n && result < n; ++i)
            result = Math.Max(Dfs(i, graph, new HashSet<int>()), result);
        return result;
    }

    public int Dfs(int i, List<List<int>> graph, HashSet<int> detonated)
    {
        if (!detonated.Contains(i))
        {
            detonated.Add(i);
            foreach (int j in graph[i])
                Dfs(j, graph, detonated);
        }
        return detonated.Count();
    }
}


/*
Jun 04, 2023 22:33
Runtime 247 ms Beats 33.33%
Memory 56.7 MB Beats 31.28%
*/

public class Solution {
    public int MaximumDetonation(int[][] bombs)
    {
        var graph = new Dictionary<int, List<int>>();
        int n = bombs.Length;

        // Build the graph
        for(int i = 0; i < n; i++)
        {
            int xi = bombs[i][0], yi = bombs[i][1], ri = bombs[i][2];
            for (int j = 0; j < n; j++)
            {
                if (i == j) continue;

                int xj = bombs[j][0], yj = bombs[j][1];

                // Create a path from node i to node j, if bomb i detonates bomb j.
                if((long)ri * ri >= (long)(xi-xj) * (xi-xj) + (long)(yi - yj) * (yi - yj))
                {
                    if (!graph.ContainsKey(i)) graph[i] = new List<int>();
                    graph[i].Add(j);
                }
            }
        }

        int answer = 0;
        for (int i = 0; i < n; i++)
            answer = Math.Max(answer, dfs(i, graph));

        return answer;
    }

    private int dfs(int i, Dictionary<int,List<int>> graph)
    {
        var stack = new Stack<int>();
        var visited = new HashSet<int>();
        stack.Push(i);
        visited.Add(i);
        while (stack.Count > 0)
        {
            int cur = stack.Pop();
            if(graph.ContainsKey(cur))
                foreach(var neib in graph[cur])
                {
                    if (!visited.Contains(neib))
                    {
                        visited.Add(neib);
                        stack.Push(neib);
                    }
                }
        }
        return visited.Count;
    }
}
