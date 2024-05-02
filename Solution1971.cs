/*
Runtime 685 ms, Beats 82.54% of users with C#
Memory 121.27 MB, Beats 94.30% of users with C#
*/

public class Solution {
    private class DisjointSetUnion
    {
        private int[] parent;
        private int N;

        public DisjointSetUnion(int n)
        {
            this.N = n;
            this.parent = new int[this.N];
            for(int i = 0; i < this.N; i++)
            {
                this.parent[i] = i;
            }
        }

        public bool areConnected(int u, int v)
        {
            return find(u) == find(v);
        }

        public void union(int u, int v)
        {
            if (u != v)
            {
                int a = find(u);
                int b = find(v);
                parent[a] = b;
            }
        }

        private int find(int u)
        {
            int x = u;
            while (x != this.parent[x])
            {
                x = this.parent[x];
            }

            parent[u] = x;
            return x;
        }
    }

    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        DisjointSetUnion set = new DisjointSetUnion(n);
        foreach (int[] edge in edges)
        {
            set.union(edge[0], edge[1]);
        }

        return set.areConnected(source, destination);
    }
}
