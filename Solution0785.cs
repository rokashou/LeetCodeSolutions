/*
May 19, 2023 21:05
Runtime 121 ms Beats 74.7%
Memory 47 MB Beats 79.1%
*/

public class Solution {    
    bool ValidColor(int[][] graph, int[] colors, int color, int node)
    {
        if (colors[node] != 0) return colors[node] == color;
        colors[node] = color;
        for(int i = 0; i < graph[node].Length; i++)
        {
            if (!ValidColor(graph, colors, -color, graph[node][i]))
                return false;
        }
        return true;
    }

    public bool IsBipartite(int[][] graph)
    {
        int n = graph.Length;
        int[] colors = new int[n];

        for(int i = 0; i < n; i++)
        {
            if (colors[i] == 0 && !ValidColor(graph, colors, 1, i))
                return false;
        }
        return true;
    }
}
