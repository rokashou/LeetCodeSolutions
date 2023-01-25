#region BFS
/*
Runtime 487 ms, Beats 28.57%
Memory 47.4 MB, Beats 85.71%
Accepted: Jan 25, 2023 16:19
*/

public class Solution {
    private void bfs(int startNode, int[] edges, int[] dist)
    {
        int n = edges.Length;
        var q = new Queue<int>();
        q.Enqueue(startNode);

        bool[] visit = new bool[n];
        Array.Fill<bool>(visit, false);
        dist[startNode] = 0;

        while(q.Count > 0)
        {
            int node = q.Dequeue();

            if (visit[node]) continue;

            visit[node] = true;
            int neighbor = edges[node];
            if(neighbor != -1 && visit[neighbor] == false)
            {
                dist[neighbor] = 1 + dist[node];
                q.Enqueue(neighbor);
            }
        }
    }

    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        int n = edges.Length;
        var dist1 = new int[n];
        var dist2 = new int[n];
        Array.Fill(dist1, int.MaxValue);
        Array.Fill(dist2, int.MaxValue);

        bfs(node1, edges, dist1);
        bfs(node2, edges, dist2);

        int minDistNode = -1, minDistTillNow = int.MaxValue;
        for(int currNode = 0; currNode < n; currNode++)
        {
            if(minDistTillNow > Math.Max(dist1[currNode], dist2[currNode]))
            {
                minDistNode = currNode;
                minDistTillNow = Math.Max(dist1[currNode], dist2[currNode]);
            }
        }

        return minDistNode;
    }
}

#endregion

#region DFS
/*
Runtime 266 ms, Beats 71.43%
Memory 56.9 MB, Beats 14.29%
Accepted: Jan 25, 2023 16:23
*/

public class Solution {
    private void dfs(int node, int[] edges, int[] dist, bool[] visit)
    {
        visit[node] = true;
        int neighbor = edges[node];
        if(neighbor != -1 && visit[neighbor] == false)
        {
            dist[neighbor] = 1 + dist[node];
            dfs(neighbor, edges, dist, visit);
        }
    }

    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        int n = edges.Length;
        var dist1 = new int[n]; // distance from node1
        var dist2 = new int[n]; // distance from node2
        Array.Fill(dist1, int.MaxValue);
        Array.Fill(dist2, int.MaxValue);
        dist1[node1] = 0;
        dist2[node2] = 0;

        var visit = new bool[n];

        Array.Fill(visit, false);
        dfs(node1, edges, dist1, visit);
        Array.Fill(visit, false);
        dfs(node2, edges, dist2, visit);

        int minDistNode = -1;
        int minDistTillNow = int.MaxValue;
        for (int currNode = 0; currNode < n; currNode++)
        {
            if (minDistTillNow > Math.Max(dist1[currNode], dist2[currNode]))
            {
                minDistNode = currNode;
                minDistTillNow = Math.Max(dist1[currNode], dist2[currNode]);
            }
        }

        return minDistNode;
    }

}

#endregion




