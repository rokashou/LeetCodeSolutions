/*
Mar 23, 2023 21:16
Runtime 185 ms, Beats 88.14%
Memory 56.7 MB, Beats 55.93%
*/

public class Solution {
    private class UnionFind
    {
        int[] parent;
        int[] rank;

        public UnionFind(int size)
        {
            parent = new int[size];
            rank = new int[size];
            for (int i = 0; i < size; i++)
            {
                parent[i] = i;
            }
        }

        public int Find(int x)
        {
            if (parent[x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        public void SetUnion(int x, int y)
        {
            int xset = Find(x), yset = Find(y);
            if (xset == yset)
                return;
            if (rank[xset] < rank[yset])
            {
                parent[xset] = yset;
            }
            else if (rank[xset] > rank[yset])
            {
                parent[yset] = xset;
            }
            else
            {
                parent[yset] = xset;
                rank[xset]++;
            }
        }
    }

    public int MakeConnected(int n, int[][] connections)
    {
        // Check the size of connections.
        // There must be more than n-1 to connect the entire graph.
        if (connections.Length < n - 1) return -1;

        // Create an instance of UnionFind of size n
        var dsu = new UnionFind(n);

        // Initialize an integer numberOfConnectedComponents which stores
        // the number of connected components in the graph. Initialize it
        // to n
        int numberOfConnectedComponents = n;

        // Iterate over all the edges and for each connection in connections:
        foreach (var connection in connections)
        {
            // Using the find operation, determine the components of both the nodes connected by connection.
            if (dsu.Find(connection[0]) != dsu.Find(connection[1]))
            {
                // If both nodes belong to different components, we use the union operation over both nodes to combine the two different connected components into a single one. We also decrement numberOfConnectedComponents by 1.
                numberOfConnectedComponents--;
                dsu.SetUnion(connection[0], connection[1]);
            }
            // Otherwise, we don't do anythiing if both nodes already belong to the same component.
        }

        // return numberOfConnectedComponents -1
        return numberOfConnectedComponents - 1;

    }
}
