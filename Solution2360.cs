/*
Approach 2: Kahn's Algorithm(BFS)
Mar 26, 2023 14:46
Runtime 262 ms, Beats 80%
Memory 51.2 MB, Beats 90%
*/
public class Solution {
    public int LongestCycle(int[] edges) {
        // Step 1. Initialize an integer n = edges.length which stores the number of nodes in the grath.
        int n = edges.Length;

        // Step 2. Create an array degree of length n where degree[x] stores the number of edges with one end at node x.
        int[] indegree = new int[n];
        foreach (var e in edges)
        {
            if (e != -1)
            {
                indegree[e]++;
            }
        }

        // Step 3. Create a visit array of length n to keep track of nodes that have been visited.
        bool[] visit = new bool[n];

        // Start of Kahn's Algorithm

        // Step 4. initialize a queue of integers q and start a BFS algorithm moving from the leaf nodes to the parent nodes.
        var q = new Queue<int>();

        // Step 5. Begin the BFS reaversal by pushingi all the leaf nodes (indegree equal to 0) in the queue.
        for (int i = 0; i < n; i++)
        {
            if (indegree[i] == 0)
            {
                q.Enqueue(i);
            }
        }

        // Step 6. While the queue is not empty:
        while (q.Count > 0)
        {
            // Step 6.1 Dequeue the first node from the queue
            int node = q.Dequeue();

            // Step 6.2 Mark node as visited
            visit[node] = true;
            // Step 6.3 Get the neighbor of node using edges[node].
            int neightbor = edges[node];
            // If neightbor != -1, we decrement indegree[neighbor] by 1.
            if (neightbor != -1)
            {
                indegree[neightbor]--;
                // Step 6.4 if indegree[neighbor] == 0, it means tha neighbor behaves as a left node, so we push neighbor in the queue.
                if (indegree[neightbor] == 0)
                {
                    q.Enqueue(neightbor);
                }
            }
        }
        // end of Kahn's algorithm


        int answer = -1;
        // Step 7. Iterate over unvisited nodes and for an unvisited node i:
        for (int i = 0; i < n; i++)
        {
            if (!visit[i])
            {
                // Step 7.1 Mark node i as visited.
                visit[i] = true;
                // Step 7.2 Fetch neightbor of i using edges[i] and create a viriable count to count number of nodes in the cycle. Initialize count = 1 to count node i itself
                int count = 1;
                int neightbor = edges[i];
                // Step 7.3 Keep moving forward in the cycle until we reach node i(neighbor != i). Mark neighbor as visited and move to next neighbor = edges[neighbor]. Also, increament count by 1 for each node that is being visited in the cycle.
                while (neightbor != i)
                {
                    visit[neightbor] = true;
                    count++;
                    neightbor = edges[neightbor];
                }
                // Step 7.4 Update answer = max(answer, count);
                answer = Math.Max(answer, count);
            }

        }
        // Step 8. Return answer
        return answer;
    }
}




/*
Approach 1: DFS
Mar 26, 2023 14:17
Runtime 423 ms, Beats 20%
Memory 75.6 MB, Beats 50%
*/

public class Solution {
    int answer = -1;

    private void dfs(int node, int[] edges, Dictionary<int, int> dist, bool[] visit)
    {
        visit[node] = true;
        int neighbor = edges[node];

        if (neighbor != -1 && !visit[neighbor])
        {
            dist[neighbor] = dist[node] + 1;
            dfs(neighbor, edges, dist, visit);
        }
        else if (neighbor != -1 && dist.ContainsKey(neighbor))
        {
            answer = Math.Max(answer, dist[node] - dist[neighbor] + 1);
        }
    }


    public int LongestCycle(int[] edges)
    {
        int n = edges.Length;
        bool[] visit = new bool[n];

        for (int i = 0; i < edges.Length; i++)
        {
            if (!visit[i])
            {
                var dist = new Dictionary<int, int>();
                dist.Add(i, 1);
                dfs(i, edges, dist, visit);
            }
        }

        return answer;
    }
}
